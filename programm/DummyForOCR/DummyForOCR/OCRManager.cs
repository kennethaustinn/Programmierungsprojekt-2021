using System;
using System.Collections.Generic;
using System.Linq;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    public class OCRManager : IOCRManager
    {
        private readonly AnalysisProgram _analysis = new AnalysisProgram();

        private string _fileName;


        private readonly HashSet<string> _documentName = new HashSet<string>()
        {
            "Biografie", "Biografie Bit" ,"Maßnahmenplan", "Pflegebericht", "Vitalwerte", "Medikamentenplan", "Krankenhausaufenthalte"
        };

        //List<string> _bioItemKeyList = new List<string>()
        //{
        //    "Schule:", "Ausbildung:", "Universität:", "Beruf:", "Partnerschaft:", "Kinder:", "Freizeit:",
        //    "Familienmitglieder:", "Sprachen:"
        //};

        //private HashSet<string> _ignoreKey = new HashSet<string>()
        //{
        //    "Schule:", "Ausbildung:", "Beruf:", "Universität:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:",
        //    "Datum:", "Vormittag:", "Mittag:", "Nachmittag:", "Abend:", "Erstellt von:",
        //    "Erfüllung vom Maßnahmenplan:", "Abweichungen:", "Erstellt von:",
        //    "Was wurde gemessen:", "Wert:", "Einheit:",
        //    "Medikament:", "Dosierung:", "Häufigkeit", "Grund:", "Verabreicht von:",
        //    "Dauer:"
        //};


        private Dictionary<string, List<string>> _recognizeKeys = new Dictionary<string, List<string>>();

        private List<List<string>> _bioItems = new List<List<string>>();

        private Dictionary<string, List<string>> _bioDictionary = new Dictionary<string, List<string>>();

        private List<string> newbioItemKeyList = new List<string>();

        private string _allResult;

        private List<string> _valueStrings;

        private List<string> _handSource;

        private int _keyForCompareDictionary;
        private string _currentDocument;
        private List<string> _currentCategory = new List<string>();
        //private OcrResult.Line[] allResultLines;
        private void ExecuteOcr()                                // Eingabeparamter noch auf Path ändern.
        {
            
            OpenFile();                                         //später path & filename als Übergabeparameter wie das Klassendiagramm einfügen.
            SearchForKeys();
            AddToDictionary();                               // es kommt zu einer Fehlermeldung, wenn man während der Laufzeit eine andere Datei auswählt -> Hashcode 
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
            //string exda = null;
            
            //foreach (var Result in ocr.ReadMultithreaded(new OcrInput(@"C:\Users\ala19\Desktop\Maßnahmenplan_Vorlage P1.png"),
            //    new OcrInput(@"C: \Users\ala19\Desktop\Maßnahmenplan_Vorlage P2.png")))
            //{
            //    Console.WriteLine(Result.Text);
            //    _allResult = Result.Text;
            //    _allResult += exda + _allResult;
            //    allResultLines = Result.Lines;
            //}
            var input = new OcrInput(_fileName);
            var ocrResult = ocr.Read(input);
            _allResult = ocrResult.Text;
            var allResultLines = ocrResult.Lines;
            //SaveAsPdfAndTextFile(ocrResult);
            _valueStrings = allResultLines.Cast<object>().Select(x => x.ToString()).ToList();

            for (int i = 0; i < _valueStrings.Count; i++)
            {
                if (_documentName.Contains(_valueStrings[i]))
                {
                    _currentDocument = _valueStrings[i];
                }
            }
            _currentCategory = _recognizeKeys[_currentDocument];

            Console.WriteLine("Datei wurde geladen!");
        }

        private void SearchForKeys()
        {
            RemoveSpaceFromList();
            ApproximateValue();
            var newArray = _valueStrings.Cast<object>().Select(x => x.ToString()).ToArray();
            int first = 0;
            int second = 0;
            List<string> bioList = new List<string>();
            List<string> sug = new List<string>();
            int tolerance = 5;
            string value = null;


            _currentCategory = newbioItemKeyList;
            for (int i = 0; i < _currentCategory.Count; i++)
            {


                if (i == _currentCategory.Count - 1)
                {
                    first = Array.IndexOf(newArray, _currentCategory[i]) + 1;
                    second = _valueStrings.IndexOf(_valueStrings[_valueStrings.Count - 1]);
                    //bioList = _valueStrings.ToList().GetRange(first, second - first + 1);
                    bioList = _valueStrings.Skip(first).Take(second).ToList();
                }
                else if (i < _currentCategory.Count)
                {
                    first = Array.IndexOf(newArray, _currentCategory[i]) + 1;
                    second = Array.IndexOf(newArray, _currentCategory[i + 1]);
                    //bioList = _valueStrings.ToList().GetRange(first, (second - first + 1));
                    bioList = _valueStrings.Skip(first).Take(second - first).ToList();
                }

                _bioItems.Add(bioList);
            }

        }

        private void ApproximateValue()
        {
            List<string> sug = new List<string>();
            List<string> substringList = new List<string>();
            int tolerance = 5;
            string asdasd = null;
            string text = null;
            for (int a = 0; a < _valueStrings.Count; a++)
            {
                var userInput = _valueStrings[a];

                for (var i = 0; i < _valueStrings.Count; i++)
                {
                    var word = _valueStrings[i];
                    int dis = _analysis.CalculateDistance(userInput, word);
                    if (dis <= tolerance)
                    {
                        sug.Add(word);
                    }
                }

                if (sug.Count > 1)
                {
                    for (int i = 0; i < sug.Count; i++)
                    {
                        if (!userInput.Equals(sug[i]))
                        {
                            sug.RemoveAt(i);
                            i--;
                        }

                    }

                }

                if (sug.Count > 0)
                {
                    if (sug[0].Length > 5)
                    {

                        float sad;
                        var sas = (float) sug[0].Length;
                        sad = (sug[0].Length / 3f);
                        var aaaaaaaaaa = sas / sad;
                        asdasd = sug[0].Substring(0, (int) aaaaaaaaaa);
                    }
                    else
                    {
                        asdasd = sug[0];
                    }

                    for (var i = 0; i < _currentCategory.Count; i++)
                    {
                        bool isInListWithSameName = sug.Contains(_currentCategory[i]);
                        bool isInListWithOtherName = sug[0].Contains(asdasd);
                        if (isInListWithSameName)
                        {
                            if (isInListWithSameName)
                            {
                                text = _currentCategory[i];
                            }

                            //if (isInListWithOtherName)
                            //{
                            //    text = "list111111" + sug[0];

                            //}
                            
                            if (!newbioItemKeyList.Contains(text))
                            {
                                newbioItemKeyList.Add(text);

                            }

                        }
                        else if (!sug.Contains(_currentCategory[i]) && isInListWithOtherName == true &&
                                 _currentCategory[i].Contains(asdasd))
                        {

                            text = sug[0];
                            if (!newbioItemKeyList.Contains(text))
                            {
                                newbioItemKeyList.Add(text);

                            }

                            break;
                        }
                    }
                }
            }
        }

        private void AddToDictionary()
        {
            for (int i = 0; i < _currentCategory.Count; i++)
            {
                _bioDictionary.Add(_currentCategory[i], _bioItems[i]); //Value für Freizeit wird noch nicht befüllt.

            }
        }

        private void RemoveSpaceFromList()
        {
            for (int highLevel = 0; highLevel < _valueStrings.Count; highLevel++)
            {
                if (_valueStrings[highLevel].Equals("") || _valueStrings[highLevel].Equals(_currentDocument))
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
            _recognizeKeys.Add("Biografie", new List<string>() { "Schule:", "Ausbildung:", "Universität:", "Beruf:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:" });
            _recognizeKeys.Add("Maßnahmenplan", new List<string>() { "Datum:", "Vormittag:", "Mittag:", "Nachmittag:", "Abend:", "Erstellt von:" });
            _recognizeKeys.Add("Pflegebericht", new List<string>() { "Datum:", "Erfüllung vom Maßnahmenplan:", "Abweichungen:", "Erstellt von:" });
            _recognizeKeys.Add("Vitalwerte", new List<string>() { "Datum:", "Was wurde gemessen:", "Wert:", "Einheit:", });
            _recognizeKeys.Add("Medikamentenplan", new List<string>() { "Datum:", "Medikament:", "Dosierung:", "Häufigkeit", "Grund:", "Verabreicht von:", });
            _recognizeKeys.Add("Krankenhausaufenthalte", new List<string>() { "Datum:", "Grund:", "Dauer:" });
        }

        private void CompareHandWithExpected()
        {

            RemoveWordForComparison();
            var sumFaultRate = 0;
            var sumCompareSourceLength = 0;
            var compareSource = _analysis.CompareDictionary[_keyForCompareDictionary];          // letztere element wieder nicht erreichbar
            for (int i = 0; i < _handSource.Count; i++)                                                  // Bedingung muss immer an der CompareSource angepasst werden.
            {
                var faultRate = _analysis.CalculateDistance(_handSource[i], compareSource[i]);
                sumFaultRate += faultRate;
                Console.WriteLine("{0} -> {1} = {2} ", _handSource[i], compareSource[i], faultRate);
                sumCompareSourceLength += compareSource[i].Length;
                _analysis.FaultRate = sumFaultRate;
            }

            Console.WriteLine(_handSource.Count + " and " + compareSource.Count);
            Console.WriteLine("\n" + _analysis.CalculateDeviationRate(sumCompareSourceLength));

        }

        #region MyRegion Menu und Konsolenbedienung der Konsolenanwendung

        //----------------------------Menu---------------------------

        public void Menu()
        {
            _analysis.AddCompareList();
            AddKeyToRecognize();
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
                        for (int i = 0; i < _bioItems.Count; i++)
                        {
                            var test = _bioItems[i];
                            for (int j = 0; j < test.Count; j++)
                            {
                                Console.WriteLine(Environment.NewLine + test[j]);
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < _bioDictionary.Count; i++)
                        {
                            var key = _bioDictionary.ElementAt(i);
                            Console.WriteLine("Key: ==> " + _bioDictionary.ElementAt(i).Key);
                            for (int j = 0; j < key.Value.Count; j++)
                            {

                                Console.WriteLine($"Value {j}: ==> " + key.Value[j]);
                            }
                            Console.WriteLine(Environment.NewLine);
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    case 5:
                        CompareHandWithExpected();
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
                        _fileName = @"C:\Users\ala19\Desktop\InkedMaßnahmenplan_Vorlage_LI.png";
                        _keyForCompareDictionary = 0;
                        return;
                    case 1:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest0.png";
                        _keyForCompareDictionary = 1;
                        return;
                    case 2:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest1.png";
                        _keyForCompareDictionary = 2;
                        return;
                    case 3:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest2.png";
                        _keyForCompareDictionary = 3;
                        return;
                    case 4:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest3.png";
                        _keyForCompareDictionary = 4;
                        return;
                    case 5:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest4.png";
                        _keyForCompareDictionary = 5;
                        return;
                    case 6:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest5.png";
                        _keyForCompareDictionary = 6;
                        return;
                    case 7:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest6.png";
                        _keyForCompareDictionary = 7;
                        return;
                    case 8:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest7.png";
                        _keyForCompareDictionary = 8;
                        return;
                    case 9:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest8.png";
                        _keyForCompareDictionary = 9;
                        return;
                    case 10:
                        _fileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest9.png";
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
                "\n(00) Erste nicht funktionierende Vorlage\n","\n(01) BioTest0\n",
                "(02) BioTest1\t", "(03) BioTest2\t", "(04) BioTest3\t", "(05) BioTest4\t", "(06) BioTest5\n", "(07) BioTest6\t", "(08) BioTest7\t", "(09) BioTest8\t", "(10) BioTest9\t"
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

        #endregion

        public Dictionary<string, string> ExecuteOCR(string path)
        {
            throw new NotImplementedException();
        }
    }
}
