using System.Globalization;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input from user
            Console.Write("Enter your name : ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your student number : ");
            string studentNumber = Console.ReadLine();

            // Store subject information with arrays (7 subjects)
            string[] results = new string[7];
            string[] subjects = new string[7];
            string[] levels = new string[7];
            int[] points = new int[7];

            // Loop through the subject. get input from user

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Enter the name of subject {0} : ", i);
                subjects[i] = Console.ReadLine();

                Console.WriteLine("Enter subject level (H/O) for subject {0} : ", i);
                levels[i] = Console.ReadLine();

                Console.WriteLine("Enter the result for subject {0} : ", i);
                results[i] = Console.ReadLine();
            }

            // Total Points method calling 
            int totalPoints = CalculatePoints(results, levels, points);

            // Display results
            



        }

        private static int CalculatePoints(string[] data, string[] levels, int[] studentPoints)
        {
            // Variables for calculating total
            int totalPoints = 0, points = 0, result = 0;

            // Initialise arrays for grade boundaries and higher level points
            int[] gradeBoundaries = new int[8] { 90, 80, 70, 60, 50, 40, 30, 0 };
            int[] higherPoints = new int[8] { 100, 88, 77, 66, 56, 46, 37, 0 };

            // Loop through grades in file 
            for (int i = 0; i < data.Length; i++)
            {
                result = int.Parse(data[i]); // Convert i'th number from file into int

                // Loop through boundaries as well
                for (int j = 0; j < gradeBoundaries.Length; j++)
                {
                    if (result >= gradeBoundaries[j]) // is the result greater/equal to to values in grade boundaries array
                    {
                        // Higher or ordinary level check
                        points = levels[i].ToLower().Equals("h") ? higherPoints[j] : ordinaryPoints[j];
                        break; // break out of nested loop at this point
                    }
                }

                studentPoints[i] = points; // Not totalPoints...
            }

            // Determining the Top 6 for points calc
            Array.Sort(studentPoints); // lowest first
            Array.Reverse(studentPoints); // highest first

            // Loop through top 6 and add to totalPoints
            for (int i = 0; i < 6; i++)
            {
                totalPoints += studentPoints[i];
            }

            return totalPoints;
        }
    
        private static void DisplayPoints(string name, StringInfo studentNo, string[] results, string[] subjects, string[] levels, int[] points, int totalPoints)
        {
            Console.Write("Name :  {0}", name);
            Console.Write("Student Number : {0}", studentNo);

            for (int i = 0; i < results.Length; i++)
            {
                Console.Write($"{subjects[i],20} {levels[i],13} {results[i], 13} {points[i], 13});
            }

            Console.WriteLine("Total points = {0}", totalPoints);
        }
   
        private static void WriteInfoToFile(string name)
        {
            // Stream writer to write to file 

        }
    }
}