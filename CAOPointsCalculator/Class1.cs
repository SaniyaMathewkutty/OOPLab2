namespace CAOPointsCalculator
{
    public class CAOCalculator
    {
        public static void DisplayPoints(string name, string studentNo, string[] results, string[] subjects, string[] levels, int[] points, int totalPoints)
        {
            Console.Write("Name :  {0}", name);
            Console.Write("Student Number : {0}", studentNo);

            for (int i = 0; i < results.Length; i++)
            {
                Console.Write($"{subjects[i],20} {levels[i],13} {results[i],13} {points[i],13}");
            }

            Console.WriteLine("Total points = {0}", totalPoints);
        }
    }
}