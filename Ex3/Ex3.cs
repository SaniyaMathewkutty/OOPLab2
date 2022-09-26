/*
    Name: Saniya Mathewkutty
    Date: 26/09/2022
    Description: Lab 1, Exercise 3: Array

Create two arrays which hold the grade boundaries and higher level point.
The grade boundaries are the marks that are on the boundary between two grades
such as 90, 80, 70 etc. Amend the program so that it makes use of the arrays
in calculating points. This program should read from a file but should output
total points to the screen and not amend the file.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read in the file

            string filePath = "results.txt";
            string[] fileContents = File.ReadAllLines(filePath); // array containing all the text in the file
        
            // Call the method to calculate points in the file
            int totalPoints = CalculatePoints(fileContents);
        
        }

        private static int CalculatePoints(string[] data) // takes in string[] data, returns an int
        {
            // Initialise arrays for grade boundaries and higher level points
            int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
            int[] higherPoints = new int[8] { 100, 88, 77, 66, 56, 46, 37, 0 };
        }
    }
}