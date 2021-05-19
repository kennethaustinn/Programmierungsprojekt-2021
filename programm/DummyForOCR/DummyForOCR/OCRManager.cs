using System;
using System.Collections.Generic;
using System.IO;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    public class OCRManager : IOCRManager
    {
        private const string FileName = @"C:\Users\ala19\source\repos\grp02\digitalisierung der Pflege\programm\DummyForOCR\DummyForOCR\Files\Pictures\Maßnahmenplan_Vorlage.png";

        private readonly List<string> _bioItemKeyList = new List<string>()
        {
            "Schule:", "Beruf:", "Universität:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:",
        };
        //List ind Dictonary umändern.

        //private string[] _bioItems = new string[8];

        private string[] _bioItems = new string[8];

        private string _allResult;
        private string _result;

        private int _a = 0;
        private int _b = 0;

        private string[] _readAllLines;
        private List<string> _valueStrings;

        public int _Id;


        public OCRManager()
        {
        }

        private void ExecuteOcr()                                // Eingabeparamter noch auf Path ändern.
        {
            OpenFile();                                         //später path & filename als Übergabeparameter wie das Klassendiagramm einfügen.
            //SearchForKeys(_key1, _a, _key2, _b);
            SearchForKeys2(_bioItemKeyList, _result, _a, _b);

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
        private static void SaveAsPdfAndTextFile(OcrResult ocrResult)
        {
            ocrResult.SaveAsTextFile(@"C:\Users\ala19\Desktop\OCR\blabla.txt");
            ocrResult.SaveAsSearchablePdf(@"C:\Users\ala19\Desktop\OCR\blabla.pdf");
        }

        private void OpenFile()
        {
            var ocr = ConfigurationOCR();

            var input = new OcrInput(FileName);
            var ocrResult = ocr.Read(input);
            _allResult = ocrResult.Text;

            SaveAsPdfAndTextFile(ocrResult);
            Console.WriteLine("Datei wurde geladen!");

            _readAllLines = File.ReadAllLines(@"C:\Users\ala19\Desktop\OCR\blabla.txt");
            _valueStrings = new List<string>(_readAllLines);

        }


        private void SearchForKeys(string key1, int a, string key2, int b)
        {
            for (int highLevel = 0; highLevel < _valueStrings.Count; highLevel++)
            {
                if (_valueStrings[highLevel].Equals(""))
                {
                    _valueStrings.RemoveAt(highLevel);
                }

                if (key1.Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                {
                    a = _valueStrings.IndexOf(_valueStrings[highLevel]);
                }

                if (key2.Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                {
                    b = _valueStrings.IndexOf(_valueStrings[highLevel]);
                }
            }

            GivExtract(a, b, _result);
        }


        private void SearchForKeys2(List<string> keys, string extract, int a, int b)
        {
            RemoveSpaceFromList();

            for (int highLevel = 0; highLevel < _valueStrings.Count; highLevel++)
            {
                int i;
                for (i = 1; i < _bioItemKeyList.Count; i++) //ohne 2 For loop i =0 setzten
                {

                    if (keys[i - 1].Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                    {
                        a = _valueStrings.IndexOf(_valueStrings[highLevel]);
                    }

                    if (keys[i].Equals(_valueStrings[highLevel], StringComparison.OrdinalIgnoreCase))
                    {
                        b = _valueStrings.IndexOf(_valueStrings[highLevel]);
                    }

                    for (int secondLevel = a; secondLevel < b; secondLevel++)
                    {
                        extract = extract + (secondLevel + _valueStrings[secondLevel]) + Environment.NewLine;

                        _bioItems[i - 1] = extract;
                    }

                    //_bioItems[i-1] = extract;
                }

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

        private void GivExtract(int a, int b, string extract)
        {
            for (int secondLevel = a; secondLevel < b; secondLevel++)
            {
                extract = extract + (secondLevel + _valueStrings[secondLevel]) + Environment.NewLine;
            }
            _result = extract;

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
                        Console.WriteLine(string.Join("Test" + Environment.NewLine, _bioItems));
                        //for (int i = 0; i < _bioItems.Length; i++)
                        //{
                        //    Console.WriteLine(_bioItems[i]);
                        //}
                        break;
                    case 3:
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
