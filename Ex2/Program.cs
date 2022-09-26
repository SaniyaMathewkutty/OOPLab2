/*
    Name: Saniya Mathewkutty
    Date: 26/09/2022
    Description: Lab 1, Exercise 2: Foreach statement with file handling

Read a text file which contains 7 grades. Calculate the total points and append this 
total to the original file. Don’t worry about Higher or Ordinary level here but use 
the points for Higher.

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

            try
            {
                string[] fileContents = File.ReadAllLines(filePath);

                int totalPoints = 0, points = 0, result = 0;
                for (int i = 0; i < fileContents.Length; i++)
                {
                    result = int.Parse(fileContents[i]);

                    if 
                }
            }
        }
    }
}