using System;
using System.Threading;

namespace Lab1
{
    public static class FirstExercise
    {
        public static void StartThreading()
        {
            var t0 = new Thread(PrintLetters);
            var t1 = new Thread(PrintNumbers);
            t0.Start();
            t1.Start();

            t0.Join();
            t1.Join();
        }

        private static void PrintLetters()
        {
            Console.WriteLine("PrintLetters started\n");

            var engAlphabet = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                Console.Write(engAlphabet[random.Next(engAlphabet.Length)]);
            }

            Console.WriteLine("\nPrintLetters finished");
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("PrintNumbers started\n");

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next(101) + " | ");
            }

            Console.WriteLine("\nPrintNumbers finished");
        }
    }
}
