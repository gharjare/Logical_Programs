using System.Diagnostics;

namespace LogicalPrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("HI");
            }

            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
                stopwatch.Elapsed);
            Console.ReadLine();

        }
    }
}
