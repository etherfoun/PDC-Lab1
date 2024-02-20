using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* First exercise *******************\n");
            FirstExercise.StartThreading();
            Console.WriteLine();

            Console.WriteLine("******************* Second exercise *******************\n");
            SecondExercise.StartThreading();
            Console.WriteLine();

            Console.WriteLine("******************* Third exercise *******************\n");
            ThirdExercise.StartThreading();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
