/*
    Name: Saniya Mathewkutty
    Date: 26/09/2022
    Description: Lab 1, Exercise 4:

    Create a method which accepts an array of grades 
    (assume higher level only) and calculates the points.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read in the file
            string file = "results.txt";
            string[] fileContents = File.ReadAllLines(file);

            int totalPoints = CalculatePoints(fileContents);

            Console.WriteLine($"Total points = {totalPoints}");

            Console.ReadLine();
        }

        private static int CalculatePoints(string[] grades)
        {
            // Variables for calculating total
            int totalPoints = 0, points = 0, result = 0;

            // Initialise arrays for grade boundaries and higher level points
            int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
            int[] higherPoints = new int[8] { 100, 88, 77, 66, 56, 46, 37, 0 };

            // Loop through grades in file in
            for (int i = 0; i < grades.Length; i++)
            {
                result = int.Parse(grades[i]); // Convert i'th number from file into int

                // Loop through boundaries as well
                for (int j = 0; j < gradeBoundaries.Length; j++)
                {
                    if (result >= gradeBoundaries[j]) // is the result greater/equal to to values in grade boundaries array
                    {
                        points = higherPoints[j];
                        break; // break out of nested loop at this point
                    }
                }

                totalPoints += points;
            }

            return totalPoints;

        }
    }
}