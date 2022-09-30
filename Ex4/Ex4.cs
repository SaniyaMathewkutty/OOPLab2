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
            int totalPoints = 0, points = 0, result = 0;
            return 0;

        }
    }
}