using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForOCR
{
    public class AnalysisProgram
    {

        public Dictionary<int, List<string> > CompareDictionary= new Dictionary<int, List<string>>();

        private int _faultRate;

        private double _deviationRate;

        public int FaultRate
        {
            get => _faultRate;
            set => _faultRate = value;
        }

        /// <summary>
        /// Methode die die CompareDictionary initialisiert. Diese beinhalten die zu erwartenden Texte, welche eingelesen werden müssten.
        /// </summary>
        public void AddCompareList()
        {
            CompareDictionary.Add(0, new List<string>() {
                "Barbarrosa Grundschule", "OSZ Lise-Meitner Schule", "HTW Berlin", "Kellner, Stabler, Arzt", "Anwalt, Anwaltr, Anwalt",
                "Test", "Test", "Test", "Test", "Test","Test"
            });
            
            CompareDictionary.Add(1, new List<string>() {
                "Otto-Hahn-Schule", "Robert-Koch-Gymnasium", "Keine", "HTW-Berlin", "Medieninformatiker", "Verheiratet seit 40 Jahren",
                "Moritz 30 Jahre", "Lena 28 Jahre", "Lesen, Spazieren, Kochen, Tanzen", "2 Kinder", "3 Brüder", "Deutsch, Spanisch"
            });

            CompareDictionary.Add(2, new List<string>() {
                "Immanuel-Kant Gymnasium", "Ich hab keine.", "Hochschule für Technik und Wirtschaft", "Conterstrike Profilegende", "Vergeben", "Nein",
                "- CounterStrike  - Rap", "- Klavier  - Fußball", "Viele", "Deutsch, Bulgarisch, Englisch, Französisch"
            });

            CompareDictionary.Add(3, new List<string>() {
                "IGS-Anna Segher Mainz", "", "HTW-Berlin", "Werkstudent", "Vergeben", "",
                "Zocken, Lesen, Spazieren,", "Freunde treffen", "Wagner Familie", "deutsch, Englisch"
            });

            CompareDictionary.Add(4, new List<string>() {
                "Sophie-Scholl Schule Berlin", "Physikalisch-technischer Assistenz", "Frei Universität Berlin", "Werkstudent", "Finanzberater", "Verheiratet",
                "Paul 10 Jahre", "Tennis, Joggen, Lesen", "Eine Schwester", "Deutsch, Englisch; Spanisch"
            });

            CompareDictionary.Add(5, new List<string>() {
                "SMAK St Louis 1 Surabaya", "", "HTW Berlin", "Student", "", "",
                ". Basketball", ". Netflix", "", "Englisch, Deutsch, Chinesisch, Indonesisch"
            });

            CompareDictionary.Add(6, new List<string>() {
                "Staatliche Gymnasium in Probolinggo", "Keine", "Europa - Universität Viadrina", "Keine", "Keine", "Keine",
                "Fußball spielen, kochen", "Vater", "Mutter", "Kleine Schwester", "Englisch, Indonesisch, Deutsch"
            });

            CompareDictionary.Add(7, new List<string>() {
                "SMA Katolik Ricci II", "insert something random here", "Technische Universität Berlin", "Software Engineer", "myself and my wine", "oshi, cleo, goldy",
                "eat, sleep, repeat", "Eltern, Geschwistern, Hunde", "Java, Python"
            });

            CompareDictionary.Add(8, new List<string>() {
                "St.Louis 1 Oberschule", "Keine", "HTW Berlin", "Student", "ledig", "Keine",
                "Sport treiben", "Spazieren gehen", "Keine", "Deutsch, Englisch, Indonesien"
            });

            CompareDictionary.Add(9, new List<string>() {
                "Madania", "Keine", "TU Berlin", "Student", "ledig :(", "0",
                "Spazieren gehen", "Keine", "Deutsch, Englisch, Indonesisch"
            });

            CompareDictionary.Add(10, new List<string>() {
                "St.Louis Surabaya", "", "TU Berlin", "Student", "Keine", "Keine",
                "-Kochen - Film gucken", "-Lesen","", "Deutsch , Indonesien ,Englisch"
            });

        }

        /// <summary>
        /// Mit der CalculateDistance Methode wird die Differenz bzw. Unterschied zwischen zwei string verglichen.
        /// Dies geschieht mit hilfe der „Levenshtein Distanz“. Dies ist ein Algorithmus der char für char die jeweiligen
        /// beiden string durchgeht und guckt wie sie sich jeweils unterscheiden.
        /// Am ende erhält man eine Distanz (Zahl), die dafür steht wie viele Operationen man benötigt um den einen string wie den anderen darstellen zulassen.
        /// Diese sind replace, delete oder insert.
        /// </summary>
        /// <param name="handwrittenSource">Hier befindet sich der handschriftliche string welcher durch OCR eingelesen wurde.</param>
        /// <param name="expectedSource">Hier befindet sich der eigentlich zu erwartende string welcher gelesen werden müsste.</param>
        /// <returns>Gibt die Distanz zurück.</returns>
        public int CalculateDistance(string handwrittenSource, string expectedSource) 
        {

            var handwrittenSourceLength = handwrittenSource.Length;
            var expectedSourceLength = expectedSource.Length;
            
            var matrix = new int[handwrittenSourceLength + 1, expectedSourceLength + 1];

            // Überprüft ob der erste string leer ist, wenn ja ist die Distanz die länge des zweiten strings.
            if (handwrittenSourceLength == 0)
                return expectedSourceLength;

            // Überprüft ob der zweite string leer ist, wenn ja ist die Distanz die länge des ersten strings.
            if (expectedSourceLength == 0)
                return handwrittenSourceLength;

            
            // Initialisierung  der Zeilenanzahl des ersten string in der Matrix. Jedes char des stings, ist dabei eine Zeile.
            for (var row = 0; row <= handwrittenSourceLength; row++)
            {
                matrix[row, 0] = row;
            }
            // Initialisierung  der Spaltenanzahl des zweiten string in der Matrix. Jedes char des stings, ist dabei eine Sapalte.
            for (var column = 0; column <= expectedSourceLength; column++)
            {
                matrix[0, column] = column;
            }

            // Hier wird die Distanz berechnet bzw. rausgefunden d.h. hier beginnt die eigetnliche Suche nach den Unterschieden.
            // Dabei wird immer das Minimum innerhalb der temporären/ aktuellen matrix gesucht. Dies geschieht bis man an der Stelle n x m ankommt 
            for (var i = 1; i <= handwrittenSourceLength; i++)
            {
                for (var j = 1; j <= expectedSourceLength; j++)
                {
                    var substitutionCount = expectedSource[j - 1] == handwrittenSource[i - 1] ? 0 : 1;           // Unterschied der zwei chars, wenn die gleich sind dann ist 
                                                                                                                    // die Differenz 0, ansonsten 1.
                    
                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1,          //delete
                                                     matrix[i, j - 1] + 1),         //insert
                                                     matrix[i - 1, j - 1] + substitutionCount);  // replace

                    //matrix[i, j] = Minimum(matrix[i - 1, j] + 1,
                    //                         matrix[i, j - 1] + 1,
                    //                         matrix[i - 1, j - 1] + cost);
                }
            }
            // Gibt die Distanz wieder zurück.
            return matrix[handwrittenSourceLength, expectedSourceLength];

        }

        //static int Minimum(int a, int b, int c)
        //{
        //    if (a > b) { a = b; }

        //    if (a > c) { a = c; }

        //    return a;
        //}


        /// <summary>
        /// Diese Methode berechnet die prozentuale Abweichung vom eingelesenen Dokumnet zu dem erwartenden Ergebnis.
        /// </summary>
        /// <param name="sourceLength">Länge der gesamten Zeichenkette, di eingelessen wurde.</param>
        /// <returns> Gibt ein string mit den wichtigsten Informationen wieder.</returns>
        public string CalculateDeviationRate(int sourceLength)
        {
            double deviation;
            if (Convert.ToDouble(sourceLength)/2 <= Convert.ToDouble(_faultRate))
            {
                 deviation = (Convert.ToDouble(_faultRate) / Convert.ToDouble(sourceLength)) * 100.0;
            }
            else
            {
                deviation = 100 - ((Convert.ToDouble(_faultRate) / Convert.ToDouble(sourceLength)) * 100.0);
            }
            
            var _deviationRate = Math.Round(deviation, 2);

            return $"Die Fehlerabweichung, der {_faultRate} Fehler im gesamten Inhalt der Länge {sourceLength} (chars), beträgt {_deviationRate} %.";

        }

    }
}
