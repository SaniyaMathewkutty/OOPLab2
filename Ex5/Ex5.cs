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

            // Loop through the subjects 

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Enter the name of subject {0} : ", i);
                subjects[i] = Console.ReadLine();

                Console.WriteLine("Enter subject level (H/O) for subject {0} : ", i);
                levels[i] = Console.ReadLine();

                Console.WriteLine("Enter the result for subject {0} : ", i);
                results[i] = Console.ReadLine();
            }




        }
    }
}