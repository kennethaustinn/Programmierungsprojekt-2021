using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommonInterfaces;
using IronOcr;

namespace DummyForOCR
{
    /// <summary>
    /// Die Klasse ist für das Managen des OCR (optical character recognition). Dieser soll Dateien/Dokumente lesen und den Text erkennen können.
    /// Das eingelesene soll dann gepeichert werden und weiter verarbeitet werden. Indem fall es auf der GUI angzeigt werden und an die Datenbank übergeben werden.
    /// Für das Projekt "Digitalisierung der Pflege" ist es einer der Hauptkerne, da es den Pflegepersonal erlcihert soll geschriebenes einzuscannen und es zu speichern.
    /// </summary>
    public class OcrManager : IOcrManager
    {
        /// <summary>
        /// Instanz der Klasse AnalysisProgram.
        /// </summary>
        private readonly AnalysisProgram _analysis = new AnalysisProgram();

        /// <summary>
        /// Parentpfad des Projekt, damit jeder der dasd Projekt hat auf die Files zugreifen kann.
        /// </summary>
        private readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName;

        /// <summary>
        /// Gibt den eingelesenen Text zurück.
        /// </summary>
        private string _allResult;

        /// <summary>
        /// Dateipfad der einzulesenden Datei.
        /// </summary>
        private string _path;

        /// <summary>
        /// Aktuelles einzulesendes Dokument z.B. Biografie oder Pflegebericht.
        /// </summary>
        private string _currentDocumentName;

        /// <summary>
        /// Key welcher an Dictionary übergeben wird, um das einzulesende mit dem passenden Originalen  vergleicht. Wird nur für das Analyse Programm verwendet.
        /// </summary>
        private int _keyForCompareDictionary;

        /// <summary>
        /// List mit der Speicherung des eingelesenen Text.
        /// </summary>
        private List<string> _resultFromOcr;

        /// <summary>
        /// Kopie der List (_resultFromOcr) des eingelesenen Textes. Wird nur für das Analyse Programm verwendet
        /// </summary>
        private List<string> _scannedSource;
        
        /// <summary>
        /// HashSet welche die Keys (Namen) für die Erkennung des einzulesenden Dokumente speichert.
        /// </summary>
        private readonly HashSet<string> _documentName = new HashSet<string>()
        {
            "Biografie", "Maßnahmenplan", "Pflegebericht", "Vitalwerte", "Medikamentenplan", "Krankenhausaufenthalte"
        };

        /// <summary>
        /// Aktuelle List mit den Keys des einzulesenden Dokuments, diese soll für die Zuordnung der zugehörigen Elemente/Values helfen. Bei Biografie z.B Schule, Beruf etc. 
        /// </summary>
        private List<string> _currentDocumentKeys = new List<string>();

        /// <summary>
        /// Kopie der List (_currentDocumentKeys), falls ein Key falsch gelesen wurde wird dieser angepasst.
        /// </summary>
        private readonly List<string> _newCurrentDocumentKeys = new List<string>();

        /// <summary>
        /// Elemente/Values zu den zugehörigen Keys des aktuellen Dokuments.
        /// </summary>
        private readonly List<List<string>> _currentDocumentItems = new List<List<string>>();
        
        /// <summary>
        /// Dictionary mit den Keys und Values des aktuellen Dokuments. Wird an die GUI/Datenbank übergeben.
        /// </summary>
        private readonly Dictionary<string, List<string>> _currentDocumentDictionary = new Dictionary<string, List<string>>();

        /// <summary>
        /// Dictionary welche für das jeweilige Dokument die Keys gespeichert hat.
        /// </summary>
        private readonly Dictionary<string, List<string>> _recognizeDocumentKeys = new Dictionary<string, List<string>>();

        /// <summary>
        /// List mit den gemerkten Stellen, wo sich der Key des aktuellen einzulesenden Dokuments vom Originalen unterscheidet.
        /// </summary>
        private readonly List<int> _noticeIndexList = new List<int>();

        /// <summary>
        /// Diese Methode befüllt die _recognizeDocumentKeys Dictionary mit den Keys und Values.
        /// Die Keys sind dabei die Namen der Dokumente  und die Values die Schlüsselwörter(Keys) des Dokuments.
        /// </summary>
        private void AddKeyToRecognize()
        {
            _recognizeDocumentKeys.Add("Biografie", new List<string>() { "Schule:", "Ausbildung:", "Universität:", "Beruf:", "Partnerschaft:", "Kinder:", "Freizeit:", "Familienmitglieder:", "Sprachen:" });
            _recognizeDocumentKeys.Add("Maßnahmenplan", new List<string>() { "Datum:", "Vormittag:", "Mittag:", "Nachmittag:", "Abend:", "Erstellt von:" });
            _recognizeDocumentKeys.Add("Pflegebericht", new List<string>() { "Datum:", "Erfüllung vom Maßnahmenplan:", "Abweichungen:", "Erstellt von:" });
            _recognizeDocumentKeys.Add("Vitalwerte", new List<string>() { "Datum:", "Was wurde gemessen:", "Wert:", "Einheit:", });
            _recognizeDocumentKeys.Add("Medikamentenplan", new List<string>() { "Datum:", "Medikament:", "Dosierung:", "Häufigkeit", "Grund:", "Verabreicht von:", });
            _recognizeDocumentKeys.Add("Krankenhausaufenthalte", new List<string>() { "Datum:", "Grund:", "Dauer:" });
        }

        /// <summary>
        /// In der Methode wird mit Hilfe des IronOcr-Nuget eine Instanz davon erstellt. Auch wird das generierte Ocr-Objekt in der Methode konfiguriert,
        /// wie zum Beispiel  welche Sprache es erknnen soll, welche Version und welche Technik zum lesen des Text verwendent werden soll.
        /// Indemfall ist es in Deutsch mit der Version Tesseract5 und der Long short-term memory (LSTM) Technik.
        /// </summary>
        /// <returns> Gibt die Instanz mit den gespeicherten Einstellung zurück.</returns>
        private IronTesseract ConfigurationOcr()
        {
            var ocr = new IronTesseract();
            ocr.Language = OcrLanguage.German;
            ocr.Configuration.TesseractVersion = TesseractVersion.Tesseract5;
            ocr.Configuration.EngineMode = TesseractEngineMode.LstmOnly;
            ocr.Configuration.BlackListCharacters = "";
            return ocr;
        }
        
        /// <summary>
        /// Die Methode führt den Kompletten Prozess des OCR-Teils durch. Dabei ruft sie drei Methoden auf:
        /// OpenFile(): Öffnet das einzulesende Dokument aus den Ordner.                                       
        /// StartSearchForItems(): Startet die Suche nach den Keys und den zugehörigen Elemente/Values.
        /// AddToDictionary(): Fügt die gefundenen Elemente/Values den Keys hinzu.
        /// </summary>
        private void ExecuteOcr()
        {
            OpenFile();                                         
            StartSearchForItems();
            AddToDictionary();
        }

        /// <summary>
        /// Die Methode öffnet mit der Ocr-Instanz, die gewählte Datei und speichert das eingelesene in der List _resultFromOcr.
        /// Es wird auch geguckt, um welches Dokument es ich handelt. Es dies gefunden wurden, wird der Name dessen in _currentDocumentName gespeichert
        /// und an _recognizeDocumentKeys, für die Ermittlung  der Keys, als Key übergeben.
        /// </summary>
        private void OpenFile()
        {
            var ocr = ConfigurationOcr();
            var input = new OcrInput(_path);
            input.Deskew();
            var ocrResult = ocr.Read(input);
            _allResult = ocrResult.Text;
            var allResultLines = ocrResult.Lines;

            _resultFromOcr = allResultLines.Cast<object>().Select(x => x.ToString()).ToList();

            foreach (var value in _resultFromOcr.Where(value => _documentName.Contains(value)))
            {
                _currentDocumentName = value;
            }
            _currentDocumentKeys = _recognizeDocumentKeys[_currentDocumentName];

            Console.WriteLine("Datei wurde geladen!");
        }
        
        /// <summary>
        /// Dieser Methode fügt der _currentDocumentDictionary die Keys und Values, aus dem gelesenen Text.
        /// Somit hat meine eine sortierte Ordnung der Keys und Values des jeweiligen Dokuments.
        /// </summary>
        private void AddToDictionary()
        {
            for (int i = 0; i < _recognizeDocumentKeys[_currentDocumentName].Count; i++)
            {
                if (i>= _currentDocumentKeys.Count) { return; }

                var isKeyAvailable = _currentDocumentKeys.Contains(_recognizeDocumentKeys[_currentDocumentName][i]);
                var isItemAvailable = _currentDocumentItems[i].Count == 0;
                if (isKeyAvailable && !isItemAvailable)
                {
                    _currentDocumentDictionary.Add(_currentDocumentKeys[i], _currentDocumentItems[i]);
                }
                else if (isKeyAvailable)
                {
                    _currentDocumentDictionary.Add(_currentDocumentKeys[i], new List<string>() { "" });
                }
                else
                {
                    _currentDocumentDictionary.Add(_recognizeDocumentKeys[_currentDocumentName][i], new List<string>(){""});
                }
            }
        }

        //------------Dieser Teil ist nur für den OCR-Manager---------------------------//

        #region Methods to extract the scanned document

        /// <summary>
        /// In der Methode fängt die Suche bzw. das Managen nach den Keys und den zugehörigen Elemente/Values.
        /// Dabei werden die ausgelagerten Methoden mit den Codeblöcken aufgerufen.
        /// </summary>
        private void StartSearchForItems()
        {
            RemoveSpaceFromList();
            ApproximateValue();

            if (_newCurrentDocumentKeys.Count != 0)
            {
                DeleteUnnecessaryKey();
                NoticeAndAddIndex();
            }

            CheckKeyItentity();
            FindItem();
        }

        /// <summary>
        /// Hier werden Leerzeichen oder der Name des Dokuments entfernt, da die für die spätere Verwendung in der List (_resultFromOcr) nicht verwendet werden.
        /// </summary>
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

        /// <summary>
        /// Falls die Keys des aktuellen Dokuments nicht richtig gelesen werden, soll Annährung/Gleichheit zu den richtigen Keys überprüft werden.
        /// Sollten die Keys im Toleranzberich sein, so werden die der _newCurrentDocumentKeys List hinzugefügt.
        /// Zur Berechnung der Annährung, wird das Analyse Programm mit dem Levenshtein Distanz Algorithmus zu Hilfe genommen.
        /// </summary>
        private void ApproximateValue()
        {
            var approach = new List<string>();                             // Die List besteht am Ende immer aus einem Element, nämlich den angenäherten Key
            foreach (var value in _resultFromOcr)
            {
                AddToApproachList(approach, value);
                RemoveFromApproachList(approach, value);
                if (approach.Count <= 0) continue;
                {
                    var substring = GiveSubstring(approach);
                    foreach (var unused in _currentDocumentKeys.Where(key => GiveNewDocumentKeys(approach, key, substring))) { break;}
                }
            }
        }

        /// <summary>
        /// Die Methode fügt der approach List den nächstmöglich angenäherten Key hinzu, falls es der Toleranzfehler zulässt.
        /// Der Toleranzfehler  darf maximal 5 sein. 
        /// </summary>
        /// <param name="approach"> List mit den angenäherten Wörter.</param>
        /// <param name="value"> Aktuller durchlaufender string/Element der _resultFromOcr List.</param>
        private void AddToApproachList(List<string> approach, string value)
        {
            const int tolerance = 5;
            approach.AddRange(from word in _resultFromOcr
                let dis = _analysis.CalculateDistance(value, word)
                where dis <= tolerance
                select word);
        }

        /// <summary>
        /// Die Methode entfernt Wörter aus der Liste falls mehr als eins vorhanden ist.
        /// Dabei wird der Eintrag entfernt, welcher nicht schon in der List ist bzw. nicht gleich dem value ist.
        /// Denn es können mehrere Annährungen mit dem Toleranzbereich  gefunden werden, jedoch will man das ähnlichste. Daher werden dann alle anderen entfernt.
        /// </summary>
        /// <param name="approach"> List mit den angenäherten Wörter.</param>
        /// <param name="value"> Aktuller durchlaufender string/Element der _resultFromOcr List.</param>
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

        /// <summary>
        /// Diese Methode soll einen Teil des strings/Wortes zurück geben. Dieser soll im besten Fall ein drittel der string Länge sein.
        /// </summary>
        /// <param name="approach"> List mit den angenäherten Wort.</param>
        /// <returns> Erstes drittel des strings.</returns>
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

        /// <summary>
        /// In der Methode werden der _newCurrentDocumentKeys List die angenährten Keys hinzugefügt.
        /// Damit die Suche nach den zugehörigen Elementen/Values ohne Fehler erfolgen kann.
        /// </summary>
        /// <param name="approach"> List mit den angenäherten Wort.</param>
        /// <param name="key"> Key aus der _currentDocumentKeys Lsit.</param>
        /// <param name="substring">Erstes drittel des strings, aus der approach List.</param>
        /// <returns> False oder True.</returns>
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

        /// <summary>
        /// Hier werden die falschen oder unnötigen zusätlichen Keys entfernt, falls die _newCurrentDocumentKeys List größer als die Originale _currentDocumentKeys ist.
        /// Damit wird verhindert das keine Exception Fehlermeldung bezüglich der Länge der Listen kommt, da die noch mit einander verglichen bzw. durchlaufen werden.
        /// </summary>
        private void DeleteUnnecessaryKey()
        {
            if (_newCurrentDocumentKeys.Count > _currentDocumentKeys.Count)
            {
                for (int i = 0; i < _newCurrentDocumentKeys.Count; i++)
                {
                    //var value = GiveSubstring(new List<string>() {_newCurrentDocumentKeys[i]});
                    if (_newCurrentDocumentKeys[i].Length < 5 || !_currentDocumentKeys.Contains(_newCurrentDocumentKeys[i]))
                    {
                        _newCurrentDocumentKeys.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// In dieser Methode werden die Elemente der Originalen List mit der neuen angenährten List verglichen.
        /// Sollten die nicht gleich ein, so wird sich der Index des Element gemerkt und der _noticeIndexList hinzugefügt.
        /// </summary>
        private void NoticeAndAddIndex()
        {
            for (int i = 0; i < _newCurrentDocumentKeys.Count; i++)
            {
                if (!_currentDocumentKeys[i].Equals(_newCurrentDocumentKeys[i]))
                {
                    _noticeIndexList.Add(i);
                }
            }
        }

        /// <summary>
        /// Die Methode überprüft, ob die Originale List mit der neuen angenährten List überschrieben werden soll.
        /// Dies passiert nur, wenn die _noticeIndexList sich keine Änderung gemerkt oder gespeichert hat.
        /// </summary>
        /// <returns> False oder True.</returns>
        private bool CheckKeyItentity()
        {
            //bool result = false;
            if (_noticeIndexList.Count != 0)
            {
                _currentDocumentKeys = _newCurrentDocumentKeys;
                //result = false;
            }
            return false;

        }

        /// <summary>
        /// Die Methode extrahiert die Elemente/Values zwischen zwei Keys immer. Und speichert die gefundenen Ergebnisse in der _currentDocumentItems List.
        /// </summary>
        private void FindItem()
        {
            var resultAsArray = _resultFromOcr.Cast<object>().Select(x => x.ToString()).ToArray();
            var itemList = new List<string>();

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

        #endregion
        
        /// <summary>
        /// Dies ist eine Methode, der Schnittstelle IOCRManager des CommonInterfaces.
        /// </summary>
        /// <param name="path"> Dateipfad der einzulesenden Datei.</param>
        /// <returns>Dictionary mit den Keys und Values des Dokuments.</returns>
        public Dictionary<string, List<string>> ExecuteOcr(string path)
        {
            //throw new NotImplementedException();
            return _currentDocumentDictionary;
        }
        
        //------------Dieser Teil ist nur für das Auswertungsprogramm-----------------------//
        
        #region Methods for the analysis program

        /// <summary>
        /// Gleiche Methode wie die RemoveSpaceFromList(), jedoch werden hier die Keys des aktuellen Dokuments entfernt.
        /// Wir nur für das Analyse Programm bzw. Auswertungsprogramm hier in der Konsolenanwendung benutzt.
        /// </summary>
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

        /// <summary>
        /// In dieser Methode wird das Ergbnis des eingelesenen Dokuments mit dem eigentlichen zu erwartenden Ergbnis verglichen.
        /// Das Vergleichen wird mit dem Analyse Programm/Auswertungsprogramm durchgeführt.
        /// In der Konsole wird die Auswertunng dann angezeigt, wie die beiden Quellen sich prozentual unterscheiden.
        /// </summary>
        private void CompareHandWithExpected()
        {
            RemoveWordForComparison();
            var sumFaultRate = 0;
            var sumCompareSourceLength = 0;
            var compareSource = _analysis.CompareDictionary[_keyForCompareDictionary];
            int countItem = 0;
            
            if (!CheckKeyItentity())
            {
                foreach (var itemToDelete in _noticeIndexList)
                {
                    _scannedSource.RemoveAt(itemToDelete);
                }

                countItem = _scannedSource.Count > compareSource.Count ? _scannedSource.Count : compareSource.Count;
            }
            for (int i = 0; i < countItem; i++)                                                  // Bedingung muss immer an der CompareSource angepasst werden.
            {
                    
                var faultRate = _analysis.CalculateDistance(_scannedSource[i], compareSource[i]);
                sumFaultRate += faultRate;
                Console.WriteLine("{0} -> {1} = {2} ", _scannedSource[i], compareSource[i], faultRate);
                sumCompareSourceLength += compareSource[i].Length;
                _analysis.FaultRate = sumFaultRate;
            }
            
            Console.WriteLine("\n" + _analysis.CalculateDeviationRate(sumCompareSourceLength));
        }

        #endregion

        //------------Dieser Teil ist nur für die Konsolenanwendung---------------------------//

        #region Menu and console-controls of the consoleapplecation

        /// <summary>
        ///  Auswahl des Menüeintrags.
        /// </summary>
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
                        CompareHandWithExpected();
                        break;
                    case 5:
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
        
        /// <summary>
        /// Gibt das Menü aus.
        /// </summary>
        private void PrintMenue()
        {
            Console.WriteLine("\n================================================================================");
            string[] menuItems =
            {
                "\n(0) Lade die Datei hoch. \n", 
                "(1) Gib das Ergbnis zurück\n",
                "(2) Speicher das Ergebnis im Objekt \n", 
                "(3) Gibe das Ergebnis weiter an DataBase\n", 
                "(4) Auswertungsprgamm starten\n", 
                "(5) Beenden\n"
            };

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(menuItems[i]);
            }
            Console.WriteLine("\n================================================================================\n");
        }

        /// <summary>
        /// Auswahl welche Datei gewählt werden soll.
        /// </summary>
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
                        _path = _projectDirectory + @"\Files\Pictures\Pflegebericht_Vorlage P1.png";
                        _keyForCompareDictionary = 0;
                        return;
                    case 1:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest0.png";
                        _keyForCompareDictionary = 1;
                        return;
                    case 2:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest1.png";
                        _keyForCompareDictionary = 2;
                        return;
                    case 3:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest2.png";
                        _keyForCompareDictionary = 3;
                        return;
                    case 4:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest3.png";
                        _keyForCompareDictionary = 4;
                        return;
                    case 5:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest4.png";
                        _keyForCompareDictionary = 5;
                        return;
                    case 6:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest5.png";
                        _keyForCompareDictionary = 6;
                        return;
                    case 7:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest6.png";
                        _keyForCompareDictionary = 7;
                        return;
                    case 8:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest7.png";
                        _keyForCompareDictionary = 8;
                        return;
                    case 9:
                        _path = _projectDirectory + @"\Files\Biopattern for Analysis Tests\BioTest8.png";
                        _keyForCompareDictionary = 9;
                        return;
                    default:
                        {
                            Console.WriteLine("Ungueltige Eingabe. Bitte ueberpruefen Sie Ihre Eingabe");
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Gibt den Namen der Datei aus.
        /// </summary>
        private void PrintImageMenu()
        {
            Console.WriteLine("\n================================================================================");
            string[] menuItems =
            {
                "\n(0) Dokument aus dem Ordner Pictures\n\nFolgende Dokumente werden zum Testen fürs Auswertungsprogramm benutzt","\n(1) BioTest0\t",
                "(2) BioTest1 (Ausreißer --> wird nicht Benutzt, sonst Fehlermeldung)\t", "(3) BioTest2\t", "(4) BioTest3\t", "(5) BioTest4\t", "(6) BioTest5\t", "(7) BioTest6\t", "(8) BioTest7\t", "(9) BioTest8\t",
            };

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(menuItems[i]);
            }
            Console.WriteLine("\n================================================================================\n");
        }

        /// <summary>
        /// Kontrolliert, dass es bei der User Eingabe keine Fehler zustande kommen.
        /// Es sollen Zahlen akzeptiert werden, keine Buchstaben oder andere Zeichen.
        /// </summary>
        /// <returns> User Eingabe</returns>
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

        //---------------------------------------//

    }
}
