using System;
using System.Collections.Generic;
using System.Linq;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    public class OCRManager : IOCRManager
    {
        //private readonly AnalysisProgram _analysis = new AnalysisProgram();

        private string _fileName;
        
        private readonly List<string> _bioItemKeyList = new List<string>()
        {
            "Schule:","Ausbildung:", "Beruf:", "Universität:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:",
        };
        

        private readonly Dictionary<string, string> _bioDictionary = new Dictionary<string, string>();

        private readonly string[] _bioItems = new string[9];

        private string _allResult;
        private string _extract;

        private string[] _readAllLines;
        private List<string> _valueStrings;
        private List<string> _handSource;

        private int _keyForCompareDictionary;


        private void ExecuteOcr()                                // Eingabeparamter noch auf Path ändern.
        {
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

        }

        private void SearchForKeys()
        {
            RemoveSpaceFromList();

            int a = 0;
            int b = 0;

            for (int highLevel = 0; highLevel < _valueStrings.Count; highLevel++)
            {
                int i;
                for (i = 1; i < _bioItemKeyList.Count; i++) //ohne 2 For loop i =0 setzten
                {

                    if (_bioItemKeyList[i - 1].Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                    {
                        a = _valueStrings.IndexOf(_valueStrings[highLevel]);
                    }

                    if (_bioItemKeyList[i].Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                    {
                        b = _valueStrings.IndexOf(_valueStrings[highLevel]);
                    }

                    for (int secondLevel = a + 1; secondLevel < b; secondLevel++)
                    {
                        _extract = _extract + (_valueStrings[secondLevel]) + Environment.NewLine;            //Evt. NewLine entfernen und anders lösen, da sonst eine Zeile zu viel ist.
                        _bioItems[i - 1] = _extract;                                                        //Item für Freizeit wird noch nicht befüllt.
                    }

                }
                _extract = null;
            }
        }

        private void AddToDictionary()
        {
            for (int i = 0; i < _bioItemKeyList.Count; i++)
            {
                _bioDictionary.Add(_bioItemKeyList[i], _bioItems[i]);                   //Value für Freizeit wird noch nicht befüllt.
            }
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
                if (_handSource[highLevel].Equals("") || _handSource[highLevel].Equals("Biografie") || _handSource[highLevel].Equals("Biografie Bit")
                                                      || _handSource[highLevel].Equals("Schule:")
                                                      || _handSource[highLevel].Equals("Ausbildung:")
                                                      || _handSource[highLevel].Equals("Beruf:")
                                                      || _handSource[highLevel].Equals("Universität:")
                                                      || _handSource[highLevel].Equals("Partnerschaft:")
                                                      || _handSource[highLevel].Equals("Kinder:")
                                                      || _handSource[highLevel].Equals("Freizeit:")
                                                      || _handSource[highLevel].Equals("Familienmitglieder:")
                                                      || _handSource[highLevel].Equals("Sprachen:"))
                {
                    _handSource.RemoveAt(highLevel);
                }
            }
        }

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

        private void CompareHandWithExpected(AnalysisProgram _analysis)
        {
            RemoveWordForComparison();
            var sumFaultRate = 0;
            var sumHandSourceLength = 0;
            
            for (int i = 0; i < _handSource.Count-1; i++) // Bedingung muss immer an der CompareSource angepasst werden.
            {
                var compareSource = _analysis.CompareDictionary[_keyForCompareDictionary]; // letztere element wieder nicht erreichbar
                var faultRate = _analysis.CalculateDistance(_handSource[i+1], compareSource[i]);
                sumFaultRate += faultRate;
                Console.WriteLine("{0} -> {1} = {2} ", _handSource[i+1], compareSource[i], faultRate);
                sumHandSourceLength += _handSource[i+1].Length;
                _analysis.FaultRate = sumFaultRate;
            }

            Console.WriteLine("\n"+_analysis.CalculateDeviationRate(sumHandSourceLength));  
        }


        private void PrintImageMenu()
        {
            Console.WriteLine("\n================================================================================");
            string[] menuItems =
            {
                "\n(00) Erste funktionierende Vorlage\n", 
                "(01)\t", "(02)\t", "(03)\t", "(04)\t", "(05)\n", "(06)\t", "(07)\t", "(08)\t", "(09)\t", "(10)\n", "(11)\t",
                "(12)\t", "(13)\t", "(14)\t", "(15)\n", "(16)\t", "(17)\t", "(18)\t", "(19)\t", "(20)\n",
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
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    default:
                        {
                            Console.WriteLine("Ungueltige Eingabe. Bitte ueberpruefen Sie Ihre Eingabe");
                        }
                        break;
                }
            }
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
