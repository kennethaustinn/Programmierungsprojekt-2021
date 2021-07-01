using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using IronOcr;


namespace OCRManager
{
    public class OCRManager : IOcrManager
    {
        
        /// <summary>
        /// Dateipfad der einzulesenden Datei.
        /// </summary>
        private string _path;

        /// <summary>
        /// Aktuelles einzulesendes Dokument z.B. Biografie oder Pflegebericht.
        /// </summary>
        private string _currentDocumentName;

        /// <summary>
        /// List mit der Speicherung des eingelesenen Text.
        /// </summary>
        private List<string> _resultFromOcr;

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
                if (i >= _currentDocumentKeys.Count) { return; }

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
                    _currentDocumentDictionary.Add(_recognizeDocumentKeys[_currentDocumentName][i], new List<string>() { "" });
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
                    foreach (var unused in _currentDocumentKeys.Where(key => GiveNewDocumentKeys(approach, key, substring))) { break; }
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
                              let dis = LevenshteinDistanzAlgorithm.CalculateDistance(value, word)
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
                var length = (float)approach[0].Length;
                var thirdOfLen = (approach[0].Length / 3f);
                var range = length / thirdOfLen;
                substring = approach[0].Substring(0, (int)range);
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

    }
}
