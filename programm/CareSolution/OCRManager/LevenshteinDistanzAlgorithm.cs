using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRManager
{
    public class LevenshteinDistanzAlgorithm
    {
        
        /// <summary>
        /// Vorerst der folgende Code dieser Methode wurde aus folgendener Quelle entnommen bzw. angeguckt:
        /// https://gist.github.com/Davidblkx/e12ab0bb2aff7fd8072632b396538560
        /// 
        /// Mit der CalculateDistance Methode wird die Differenz bzw. Unterschied zwischen zwei string verglichen.
        /// Dies geschieht mit hilfe der „Levenshtein Distanz“. Dies ist ein Algorithmus der char für char die jeweiligen
        /// beiden string durchgeht und guckt, wie sie sich jeweils unterscheiden.
        /// Am Ende erhält man eine Distanz (Zahl), die dafür steht wie viele Operationen man benötigt um den einen string wie den anderen darstellen zulassen.
        /// Diese sind replace, delete oder insert.
        /// </summary>
        /// <param name="scannedSource">Hier befindet sich der handschriftliche string welcher durch OCR eingelesen wurde.</param>
        /// <param name="expectedSource">Hier befindet sich der eigentlich zu erwartende string welcher gelesen werden müsste.</param>
        /// <returns>Gibt die Distanz zurück.</returns>
        public static int CalculateDistance(string scannedSource, string expectedSource)
        {

            var scannedSourceLength = scannedSource.Length;
            var expectedSourceLength = expectedSource.Length;

            var matrix = new int[scannedSourceLength + 1, expectedSourceLength + 1];

            // Überprüft ob der erste string leer ist, wenn ja ist die Distanz die länge des zweiten strings.
            if (scannedSourceLength == 0)
                return expectedSourceLength;

            // Überprüft ob der zweite string leer ist, wenn ja ist die Distanz die länge des ersten strings.
            if (expectedSourceLength == 0)
                return scannedSourceLength;


            // Initialisierung  der Zeilenanzahl des ersten string in der Matrix. Jedes char des stings, ist dabei eine Zeile.
            for (var row = 0; row <= scannedSourceLength; row++)
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
            for (var i = 1; i <= scannedSourceLength; i++)
            {
                for (var j = 1; j <= expectedSourceLength; j++)
                {
                    var substitutionCount = expectedSource[j - 1] == scannedSource[i - 1] ? 0 : 1;           // Unterschied der zwei chars, wenn die gleich sind dann ist 
                                                                                                             // die Differenz 0, ansonsten 1.

                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1,                          // delete
                                                     matrix[i, j - 1] + 1),                         // insert
                                                     matrix[i - 1, j - 1] + substitutionCount);     // replace

                }
            }
            // Gibt die Distanz wieder zurück.
            return matrix[scannedSourceLength, expectedSourceLength];
        }

    }
}
