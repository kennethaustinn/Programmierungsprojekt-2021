using System;
using System.Collections.Generic;
using System.Linq;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    public class OcrManager : IOCRManager
    {

        private string _allResult;

        private readonly AnalysisProgram _analysis = new AnalysisProgram();

        private string _path;
        
        private string _currentDocumentName;

        private int _keyForCompareDictionary;

        private List<string> _resultFromOcr;
        
        private List<string> _scannedSource;
        
        private readonly HashSet<string> _documentName = new HashSet<string>()
        {
            "Biografie", "Maßnahmenplan", "Pflegebericht", "Vitalwerte", "Medikamentenplan", "Krankenhausaufenthalte"
        };

        private List<string> _currentDocumentKeys = new List<string>();
        
        private readonly List<string> _newCurrentDocumentKeys = new List<string>();

        private readonly List<List<string>> _currentDocumentItems = new List<List<string>>();
        
        private readonly Dictionary<string, List<string>> _currentDocumentDictionary = new Dictionary<string, List<string>>();
        
        private readonly Dictionary<string, List<string>> _recognizeDocumentKeys = new Dictionary<string, List<string>>();
        
        private void AddKeyToRecognize()
        {
            _recognizeDocumentKeys.Add("Biografie", new List<string>() { "Schule:", "Ausbildung:", "Universität:", "Beruf:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:" });
            _recognizeDocumentKeys.Add("Maßnahmenplan", new List<string>() { "Datum:", "Vormittag:", "Mittag:", "Nachmittag:", "Abend:", "Erstellt von:" });
            _recognizeDocumentKeys.Add("Pflegebericht", new List<string>() { "Datum:", "Erfüllung vom Maßnahmenplan:", "Abweichungen:", "Erstellt von:" });
            _recognizeDocumentKeys.Add("Vitalwerte", new List<string>() { "Datum:", "Was wurde gemessen:", "Wert:", "Einheit:", });
            _recognizeDocumentKeys.Add("Medikamentenplan", new List<string>() { "Datum:", "Medikament:", "Dosierung:", "Häufigkeit", "Grund:", "Verabreicht von:", });
            _recognizeDocumentKeys.Add("Krankenhausaufenthalte", new List<string>() { "Datum:", "Grund:", "Dauer:" });
        }

        private void ExecuteOcr()                                // Eingabeparamter noch auf Path ändern.
        {
            OpenFile();                                         //später path & filename als Übergabeparameter wie das Klassendiagramm einfügen.
            SearchForKeys();
            AddToDictionary();                               // es kommt zu einer Fehlermeldung, wenn man während der Laufzeit eine andere Datei auswählt -> Hashcode 
        }

        #region Methods for the OCR configuration and file manager

        
        private static IronTesseract ConfigurationOcr()
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

        private void OpenFile()
        {
            var ocr = ConfigurationOcr();
            var input = new OcrInput(_path);
            var ocrResult = ocr.Read(input);
            _allResult = ocrResult.Text;
            var allResultLines = ocrResult.Lines;
            //SaveAsPdfAndTextFile(ocrResult);
            _resultFromOcr = allResultLines.Cast<object>().Select(x => x.ToString()).ToList();

            foreach (var value in _resultFromOcr.Where(value => _documentName.Contains(value)))
            {
                _currentDocumentName = value;
            }
            _currentDocumentKeys = _recognizeDocumentKeys[_currentDocumentName];

            Console.WriteLine("Datei wurde geladen!");
        }

        //private static void SaveAsPdfAndTextFile(OcrResult ocrResult)
        //{
        //    ocrResult.SaveAsTextFile(@"C:\Users\ala19\Desktop\OCR\blabla.txt");
        //    ocrResult.SaveAsSearchablePdf(@"C:\Users\ala19\Desktop\OCR\blabla.pdf");
        //}
        
        #endregion
        
        #region Methods to extract the scanned document 


        private void SearchForKeys()
        {
            RemoveSpaceFromList();
            ApproximateValue();

            var resultAsArray = _resultFromOcr.Cast<object>().Select(x => x.ToString()).ToArray();
            var itemList = new List<string>();
            _currentDocumentKeys = _newCurrentDocumentKeys;

            for (int i = 0; i < _currentDocumentKeys.Count; i++)
            {
                int upperBound;
                int lowerBound;
                if (i == _currentDocumentKeys.Count - 1)
                {
                    upperBound = Array.IndexOf(resultAsArray, _currentDocumentKeys[i]) + 1;
                    lowerBound = _resultFromOcr.IndexOf(_resultFromOcr[_resultFromOcr.Count - 1]);
                    itemList = _resultFromOcr.Skip(upperBound).Take(lowerBound).ToList();
                }
                else if (i < _currentDocumentKeys.Count)
                {
                    upperBound = Array.IndexOf(resultAsArray, _currentDocumentKeys[i]) + 1;
                    lowerBound = Array.IndexOf(resultAsArray, _currentDocumentKeys[i + 1]);
                    itemList = _resultFromOcr.Skip(upperBound).Take(lowerBound - upperBound).ToList();
                }
                _currentDocumentItems.Add(itemList);
            }
        }
        
        private void RemoveSpaceFromList()
        {
            for (int i = 0; i < _resultFromOcr.Count; i++)
            {
                if (_resultFromOcr[i].Equals("") || _resultFromOcr[i].Equals(_currentDocumentName))
                {
                    _resultFromOcr.RemoveAt(i);
                }
            }
        }

        private void ApproximateValue()
        {
            var approach = new List<string>();
            const int tolerance = 5;
            foreach (var value in _resultFromOcr)
            {
                AddToApproachList(approach, value, tolerance);
                RemoveFromApproachList(approach, value);
                if (approach.Count <= 0) continue;
                {
                    var substring = GiveSubstring(approach);
                    foreach (var unused in _currentDocumentKeys.Where(key => GiveNewDocumentKeys(approach, key, substring))) { break;}
                }
            }
        }
        
        private void AddToApproachList(List<string> approach, string value, int tolerance)
        {
            approach.AddRange(from word in _resultFromOcr
                let dis = _analysis.CalculateDistance(value, word)
                where dis <= tolerance
                select word);
        }
        
        private static void RemoveFromApproachList(List<string> approach, string value)
        {
            if (approach.Count > 1)
            {
                for (int i = 0; i < approach.Count; i++)
                {
                    if (value.Equals(approach[i])) continue;
                    approach.RemoveAt(i);
                    i--;
                }
            }
        }
        private static string GiveSubstring(List<string> approach)
        {
            string substring;
            if (approach[0].Length > 5)
            {
                var length = (float) approach[0].Length;
                var thirdOfLen = (approach[0].Length / 3f);
                var range = length / thirdOfLen;
                substring = approach[0].Substring(0, (int) range);
            }
            else
            {
                substring = approach[0];
            }

            return substring;
        }

        private bool GiveNewDocumentKeys(List<string> approach, string key, string substring)
        {
            var isInListWithSameName = approach.Contains(key);
            var isInListWithOtherName = approach[0].Contains(substring);

            if (isInListWithSameName && !_newCurrentDocumentKeys.Contains(key))
            {
                _newCurrentDocumentKeys.Add(key);
            }
            else if (!approach.Contains(key) && isInListWithOtherName && key.Contains(substring)
                     && !_newCurrentDocumentKeys.Contains(approach[0]))
            {
                _newCurrentDocumentKeys.Add(approach[0]);
                return true;
            }

            return false;
        }

        private void AddToDictionary()
        {
            for (int i = 0; i < _currentDocumentKeys.Count; i++)
            {
                _currentDocumentDictionary.Add(_currentDocumentKeys[i], _currentDocumentItems[i]);

            }
        }
        
        #endregion
        
        #region Methods for the analysis program


        private void RemoveWordForComparison()
        {
            _scannedSource = new List<string>(_resultFromOcr);
            for (int i = 0; i < _scannedSource.Count; i++)
            {
                if (_recognizeDocumentKeys[_currentDocumentName].Contains(_scannedSource[i]))
                {
                    _scannedSource.RemoveAt(i);
                }

            }
        }

        private void CompareHandWithExpected()
        {

            RemoveWordForComparison();
            var sumFaultRate = 0;
            var sumCompareSourceLength = 0;
            var compareSource = _analysis.CompareDictionary[_keyForCompareDictionary];          // letztere element wieder nicht erreichbar
            for (int i = 0; i < _scannedSource.Count; i++)                                                  // Bedingung muss immer an der CompareSource angepasst werden.
            {
                var faultRate = _analysis.CalculateDistance(_scannedSource[i], compareSource[i]);
                sumFaultRate += faultRate;
                Console.WriteLine("{0} -> {1} = {2} ", _scannedSource[i], compareSource[i], faultRate);
                sumCompareSourceLength += compareSource[i].Length;
                _analysis.FaultRate = sumFaultRate;
            }

            Console.WriteLine(_scannedSource.Count + " and " + compareSource.Count);
            Console.WriteLine("\n" + _analysis.CalculateDeviationRate(sumCompareSourceLength));

        }

        #endregion
        
        #region Menu and console-controls of the consoleapplecation


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
                        for (int i = 0; i < _currentDocumentItems.Count; i++)
                        {
                            var test = _currentDocumentItems[i];
                            for (int j = 0; j < test.Count; j++)
                            {
                                Console.WriteLine(Environment.NewLine + test[j]);
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < _currentDocumentDictionary.Count; i++)
                        {
                            var key = _currentDocumentDictionary.ElementAt(i);
                            Console.WriteLine("Key: ==> " + _currentDocumentDictionary.ElementAt(i).Key);
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
                        _path = @"C:\Users\ala19\Desktop\InkedMaßnahmenplan_Vorlage_LI.png";
                        _keyForCompareDictionary = 0;
                        return;
                    case 1:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest0.png";
                        _keyForCompareDictionary = 1;
                        return;
                    case 2:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest1.png";
                        _keyForCompareDictionary = 2;
                        return;
                    case 3:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest2.png";
                        _keyForCompareDictionary = 3;
                        return;
                    case 4:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest3.png";
                        _keyForCompareDictionary = 4;
                        return;
                    case 5:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest4.png";
                        _keyForCompareDictionary = 5;
                        return;
                    case 6:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest5.png";
                        _keyForCompareDictionary = 6;
                        return;
                    case 7:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest6.png";
                        _keyForCompareDictionary = 7;
                        return;
                    case 8:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest7.png";
                        _keyForCompareDictionary = 8;
                        return;
                    case 9:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest8.png";
                        _keyForCompareDictionary = 9;
                        return;
                    case 10:
                        _path = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Biopattern for Analysis Tests\BioTest9.png";
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
            try
            {
                var choiceInternal = int.Parse(Console.ReadLine() ?? string.Empty);
                return choiceInternal;
            }
            catch (Exception)
            {
                Console.WriteLine("Eingabe nicht korekt versuchen sie nochmal:\t");
                return ReadUserInputForInt();
            }
        }

        #endregion
        

        public Dictionary<string, string> ExecuteOCR(string path)
        {
            throw new NotImplementedException();
        }
    }
}
