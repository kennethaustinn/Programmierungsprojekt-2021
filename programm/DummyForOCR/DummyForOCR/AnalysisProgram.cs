using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForOCR
{
    public class AnalysisProgram
    {

        public readonly List<string> CompareList = new List<string>()
        {
            "Barbarrosa Grundschule", "OSZ Lise-Meitner Schule", "HTW Berlin", "Kellner, Stabler, Arzt", "Anwalt, Anwaltr, Anwalt", "Test", "Test", "Test", "Test", "Test",
        };


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
    }
}
