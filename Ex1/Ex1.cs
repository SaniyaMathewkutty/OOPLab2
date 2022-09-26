/*
    Name: Saniya Mathewkutty
    Date: 26/09/2022
    Description: Lab 1, Exercise 1

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
            string filePath = "results.txt"; // No file path because this text file is in the net6.0 folder in Debug

            try // start of try block
            {
                // Read in all the lines in the file that is in string filePath
                string[] fileContents = File.ReadAllLines(filePath);

                // Calculate total
                int totalPoints = 0, points = 0, result = 0;
                for (int i = 0; i < fileContents.Length; i++)
                {
                    result = int.Parse(fileContents[i]);

                    // if/else statements that calculate the relevant points (for Higher)
                    if (result >= 90)
                        points = 100;
                    else if (result >= 80)
                        points = 88;
                    else if (result >= 80)
                        points = 77;
                    else if (result >= 80)
                        points = 66;
                    else if (result >= 80)
                        points = 56;
                    else if (result >= 80)
                        points = 46;
                    else if (result >= 80)
                        points = 37;
                    else
                        points = 0;

                    // Append the points to totalPoints after calculation
                    totalPoints += points;

                }
                // Append the file
                File.AppendAllText(filePath, Environment.NewLine + "Total Points: " + totalPoints.ToString());

            }
            catch(IOException io) // Catches an error for input/output 
            {
                Console.Write(io.Message);
            }

        }
    }
}