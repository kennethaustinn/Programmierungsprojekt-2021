using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    public class OCRManager : IOCRManager
    {
        //private readonly AnalysisProgram _analysis = new AnalysisProgram();

        private string _fileName;


        private readonly HashSet<string> _documentName = new HashSet<string>()
        {
            "Biografie", "Maßnahmenplan", "Pflegebericht", "Vitalwerte", "Medikamentenplan", "Krankenhausaufenthalte"
        };

        private static readonly List<string> _bioItemKeyList = new List<string>()
        {
            "Schule:", "Ausbildung:", "Universität:", "Beruf:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:"
        };

        //private HashSet<string> _ignoreKey = new HashSet<string>()
        //{
        //    "Schule:", "Ausbildung:", "Beruf:", "Universität:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:",
        //    "Datum:", "Vormittag:", "Mittag:", "Nachmittag:", "Abend:", "Erstellt von:",
        //    "Erfüllung vom Maßnahmenplan:", "Abweichungen:", "Erstellt von:",
        //    "Was wurde gemessen:", "Wert:", "Einheit:",
        //    "Medikament:", "Dosierung:", "Häufigkeit", "Grund:", "Verabreicht von:",
        //    "Dauer:"
        //};


        private Dictionary<string, HashSet<string>> _recognizeKeys = new Dictionary<string, HashSet<string>>();

        private readonly Dictionary<string, string> _bioDictionary = new Dictionary<string, string>();

        private readonly string[] _bioItems = new string[_bioItemKeyList.Count];

        private string _allResult;
        private string _extract;

        private string[] _readAllLines;
        private List<string> _valueStrings;
        private List<string> _handSource;

        private int _keyForCompareDictionary;
        private string _currentDocument;


        private void ExecuteOcr()                                // Eingabeparamter noch auf Path ändern.
        {
            AddKeyToRecognize();
            OpenFile();                                         //später path & filename als Übergabeparameter wie das Klassendiagramm einfügen.
            SearchForKeys();
            //AddToDictionary();                               // es kommt zu einer Fehlermeldung, wenn man während der Laufzeit eine andere Datei auswählt -> Hashcode 
        }

        private static IronTesseract ConfigurationOCR()
        {
            var ocr = new IronTesseract();
            //var input = new OcrInput(@"C:\Users\ala19\Desktop\testdata.png"); //_filename später
            ocr.Language = OcrLanguage.German;
            ocr.Configuration.TesseractVersion = TesseractVersion.Tesseract5;
            ocr.Configuration.EngineMode = TesseractEngineMode.LstmOnly;
            ocr.Configuration.BlackListCharacters = "";
            //var abc = OcrResult.TextFlow.LeftToRight;
            return ocr;
        }

        //private static void SaveAsPdfAndTextFile(OcrResult ocrResult)
        //{
        //    ocrResult.SaveAsTextFile(@"C:\Users\ala19\Desktop\OCR\blabla.txt");
        //    ocrResult.SaveAsSearchablePdf(@"C:\Users\ala19\Desktop\OCR\blabla.pdf");
        //}

        private void OpenFile()
        {
            var ocr = ConfigurationOCR();

            var input = new OcrInput(_fileName);
            var ocrResult = ocr.Read(input);
            _allResult = ocrResult.Text;
            var allResultLines = ocrResult.Lines;

            //SaveAsPdfAndTextFile(ocrResult);
            Console.WriteLine("Datei wurde geladen!");

            _readAllLines = allResultLines.Cast<object>().Select(x => x.ToString()).ToArray();
            _valueStrings = new List<string>(_readAllLines);


            for (int i = 0; i < _valueStrings.Count; i++)
            {
                if (_documentName.Contains(_valueStrings[i]))
                {
                    _currentDocument = _valueStrings[i];
                }
            }
        }

        private void SearchForKeys()
        {
            RemoveSpaceFromList();

            int a = 0;
            int b = 0;
            int i;
            string abc = null;
            string def = null;
            for (int highLevel = 0; highLevel < _valueStrings.Count; highLevel++)
            {
                for (i = 1; i < _bioItemKeyList.Count; i++) //ohne 2 For loop i =0 setzten
                {
                    
                    if (_bioItemKeyList[i - 1].Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                    {
                        a = _valueStrings.IndexOf(_valueStrings[highLevel]);
                        abc = _bioItemKeyList[i - 1];
                    }

                    if (_bioItemKeyList[i].Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                    {
                        b = _valueStrings.IndexOf(_valueStrings[highLevel]);
                        def = _bioItemKeyList[i];
                    }

                    string pattern = string.Format(@"\b{0}\w*\b{1}", abc, def);

                    for (int secondLevel = a + 1; secondLevel < b; secondLevel++)
                    {
                        var ma = Regex.Match(_valueStrings[secondLevel], pattern, RegexOptions.IgnoreCase);
                        _extract = _extract + ma + Environment.NewLine;            //Evt. NewLine entfernen und anders lösen, da sonst eine Zeile zu viel ist.
                        _bioItems[i - 1] = _extract;                                                        //Item für Freizeit wird noch nicht befüllt.
                    }

                    _extract = null;
                }
            }
        }

        private void AddToDictionary()
        {
            for (int i = 0; i < _bioItemKeyList.Count; i++)
            {
                _bioDictionary.Add(_bioItemKeyList[i], _bioItems[i]); //Value für Freizeit wird noch nicht befüllt.
                
            }

            //HashSet<string>.Enumerator em = _recognizeKeys[_currentDocument].GetEnumerator();
            //int i = -1;
            //while (em.MoveNext())
            //{
            //    string val = em.Current;
            //    _bioDictionary.Add(val, _bioItems[i]);
            //    i++;
            //}
        }

        private void RemoveSpaceFromList()
        {
            for (int highLevel = 0; highLevel < _valueStrings.Count; highLevel++)
            {
                if (_valueStrings[highLevel].Equals("") || _valueStrings[highLevel].Equals("Biografie"))
                {
                    _valueStrings.RemoveAt(highLevel);
                }
            }
        }

        private void RemoveWordForComparison()
        {
            _handSource = _valueStrings;
            for (int highLevel = 0; highLevel < _handSource.Count; highLevel++)
            {
                if (_recognizeKeys[_currentDocument].Contains(_handSource[highLevel]))
                {
                    _handSource.RemoveAt(highLevel);
                }

            }
        }

        public void AddKeyToRecognize()
        {
            _recognizeKeys.Add("Biografie", new HashSet<string>() { "Schule:", "Beruf:", "Universität:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:", "Ausbildung:" });
            _recognizeKeys.Add("Maßnahmenplan", new HashSet<string>() { "Datum:", "Vormittag:", "Mittag:", "Nachmittag:", "Abend:", "Erstellt von:" });
            _recognizeKeys.Add("Pflegebericht", new HashSet<string>() { "Datum:", "Erfüllung vom Maßnahmenplan:", "Abweichungen:", "Erstellt von:" });
            _recognizeKeys.Add("Vitalwerte", new HashSet<string>() { "Datum:", "Was wurde gemessen:", "Wert:", "Einheit:", });
            _recognizeKeys.Add("Medikamentenplan", new HashSet<string>() { "Datum:", "Medikament:", "Dosierung:", "Häufigkeit", "Grund:", "Verabreicht von:", });
            _recognizeKeys.Add("Krankenhausaufenthalte", new HashSet<string>() { "Datum:", "Grund:", "Dauer:" });
        }
        
        private void CompareHandWithExpected(AnalysisProgram _analysis)
        {
            
            RemoveWordForComparison();
            var sumFaultRate = 0;
            var sumHandSourceLength = 0;
            var compareSource = _analysis.CompareDictionary[_keyForCompareDictionary];          // letztere element wieder nicht erreichbar
            for (int i = 0; i < _handSource.Count; i++)                                                  // Bedingung muss immer an der CompareSource angepasst werden.
            {
                var faultRate = _analysis.CalculateDistance(_handSource[i], compareSource[i]);
                sumFaultRate += faultRate;
                Console.WriteLine("{0} -> {1} = {2} ", _handSource[i], compareSource[i], faultRate);
                sumHandSourceLength += _handSource[i].Length;
                _analysis.FaultRate = sumFaultRate;
            }

            Console.WriteLine("\n" + _analysis.CalculateDeviationRate(sumHandSourceLength));
            Console.WriteLine(_currentDocument);
        }



        //----------------------------Menu---------------------------

        public void Menu(AnalysisProgram analysis)
        {
            
            while (true)
            {
                PrintMenue();
                Console.WriteLine("Bitte, geben Sie die Nummer des gewaehlten Menueeintrags ein:");
                int choice = ReadUserInputForInt();
                switch (choice)
                {
                    case 0:
                        ChooseFile();
                        ExecuteOcr();
                        break;
                    case 1:
                        Console.WriteLine(_allResult);
                        break;
                    case 2:
                        //Console.WriteLine(string.Join("" + Environment.NewLine, _bioItems ));      // Array zu string konventieren 
                        for (int i = 0; i < _bioItems.Length; i++)
                        {
                            Console.WriteLine(Environment.NewLine + _bioItems[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < _bioDictionary.Count; i++)
                        {
                            Console.WriteLine("Key: ==> " + _bioDictionary.ElementAt(i).Key);
                            Console.WriteLine("Value: ==> " + _bioDictionary.ElementAt(i).Value);
                        }
                       
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    case 5:
                        CompareHandWithExpected(analysis);
                        break;
                    default:
                        {
                            Console.WriteLine("Ungueltige Eingabe. Bitte ueberpruefen Sie Ihre Eingabe");
                        }
                        break;
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }
        private void PrintMenue()
        {
            Console.WriteLine("\n================================================================================");
            string[] menuItems =
            {
                "\n(00) Lade die Datei hoch. \n", "(01) Gib das Ergbnis zurück\n",
                "(02) Speicher das Ergebnis im Objekt \n", "(03) Gibe das Ergebnis weiter an DataBase\n", "(04) Beenden\n", "(05) Value Ausgabe\n"
            };

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(menuItems[i]);
            }
            Console.WriteLine("\n================================================================================\n");
        }

        private void ChooseFile() 
        {
            while (true)
            {
                PrintImageMenu();
                Console.WriteLine("Bitte, geben Sie die Nummer der gewünschten Datei ein:");
                int choice = ReadUserInputForInt();
                switch (choice)
                {
                    case 0:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Pictures\Vorlage1.png";
                        _keyForCompareDictionary = 0;
                        return;
                    case 1:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio_Vorlage 1 P1.png";
                        _keyForCompareDictionary = 1;
                        return;
                    case 2:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\1.png";
                        _keyForCompareDictionary = 2;
                        return;
                    case 3:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\2.png";
                        _keyForCompareDictionary = 3;
                        return;
                    case 4:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\3.png";
                        _keyForCompareDictionary = 4;
                        return;
                    case 5:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio1.png";
                        _keyForCompareDictionary = 5;
                        return;
                    case 6:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio2.png";
                        _keyForCompareDictionary = 6;
                        return;
                    case 7:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio3.png";
                        _keyForCompareDictionary = 7;
                        return;
                    case 8:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio4.png";
                        _keyForCompareDictionary = 8;
                        return;
                    case 9:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio5.png";
                        _keyForCompareDictionary = 9;
                        return;
                    case 10:
                        _fileName = @"C:\Users\ala19\Desktop\OCR\Auswertungsprogramm\Bio6.png";
                        _keyForCompareDictionary = 10;
                        return;
                    default:
                        {
                            Console.WriteLine("Ungueltige Eingabe. Bitte ueberpruefen Sie Ihre Eingabe");
                        }
                        break;
                }
            }
        }
        
        private void PrintImageMenu()
        {
            Console.WriteLine("\n================================================================================");
            string[] menuItems =
            {
                "\n(00) Erste funktionierende Vorlage\n","\n(01) Bio_Vorlage\n",
                "(02) 1\t", "(03) 2\t", "(04) 3\t", "(05) Bio1\t", "(06) Bio2\n", "(07) Bio3\t", "(08) Bio4\t", "(09) Bio5\t", "(10) Bio6\t"
            };

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(menuItems[i]);
            }
            Console.WriteLine("\n================================================================================\n");
        }

        private int ReadUserInputForInt()
        {
            bool valid = true;
            int choiceInternal = -1;
            while (valid)
            {
                try
                {
                    choiceInternal = int.Parse(Console.ReadLine() ?? string.Empty);
                    valid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Eingabe nicht korekt versuchen sie nochmal:\t");
                    int.Parse(Console.ReadLine() ?? string.Empty);
                }
            }
            return choiceInternal;
        }

        public Dictionary<string, string> ExecuteOCR(string path)
        {
            throw new NotImplementedException();
        }
    }
}
