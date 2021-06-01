using System;
using System.Collections.Generic;
using System.Linq;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    public class OCRManager : IOCRManager
    {
        private const string FileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Pictures\Vorlage1.png";

        private readonly List<string> _bioItemKeyList = new List<string>()
        {
            "Schule:", "Beruf:", "Universität:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:",
        };

        private readonly Dictionary<string, string> _bioDictionary = new Dictionary<string, string>();

        private readonly string[] _bioItems = new string[8];

        private string _allResult;
        private string _extract;

        private string[] _readAllLines;
        private List<string> _valueStrings;


        private void ExecuteOcr()                                // Eingabeparamter noch auf Path ändern.
        {
            OpenFile();                                         //später path & filename als Übergabeparameter wie das Klassendiagramm einfügen.
            SearchForKeys();
            AddToDictionary();
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

            var input = new OcrInput(FileName);
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
                if (_valueStrings[highLevel].Equals(""))
                {
                    _valueStrings.RemoveAt(highLevel);
                }
            }
        }

        public void Menu()
        {
            while (true)
            {
                PrintMenue();
                Console.WriteLine("Bitte, geben Sie die Nummer des gewaehlten Menueeintrags ein:");
                int choice = ReadUserInputForInt();
                switch (choice)
                {
                    case 0:
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
                "(02) Speicher das Ergebnis im Objekt \n", "(03) Gibe das Ergebnis weiter an DataBase\n", "(04) Beenden\n"
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
