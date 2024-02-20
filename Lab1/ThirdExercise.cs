using System;
using System.Linq;
using System.Threading;

namespace Lab1
{
    public static class ThirdExercise
    {
        public static void StartThreading()
        {
            Console.WriteLine("First array:");
            var xArray = CreateArray(10, 0, 25);
            Console.WriteLine("Second array:");
            var yArray = CreateArray(15, -10, 10);

            var t0 = new Thread(() => FirstThreadCalc(xArray));
            var t1 = new Thread(() => SecondThreadCalc(yArray));

            t0.Priority = ThreadPriority.Lowest;
            t1.Priority = ThreadPriority.BelowNormal;

            t0.Start();
            t1.Start();

            t0.Join();
            t1.Join();
        }

        private static double[] CreateArray(int size, int minValue, int maxValue)
        {
            var array = new double[size];
            var random = new Random();


            for (int i = 0; i < size; i++)
            {
                var randomValue = random.NextDouble() * (maxValue + Math.Abs(minValue)) - Math.Abs(minValue);
                array[i] = Math.Round(randomValue, 2);
                Console.Write(array[i] + " | ");
            }

            Console.WriteLine();

            return array;
        }

        private static void FirstThreadCalc(double[] xArray)
        {
            double result = 0;

            Console.WriteLine("T0 start:");
            for (int i = 0; i < xArray.Length; i++)
            {
                var argument = xArray[i];
                result += Math.Pow(argument * Math.Sin(Math.Pow(argument * Math.PI / 180, 2)), 1.0 / 3.0);
                Console.Write(Math.Round(result, 2) + " | ");
            }

            Console.WriteLine("T0 complete");
        }

        private static void SecondThreadCalc(double[] yArray)
        {
            double result = 0;

            Console.WriteLine("T1 start:");
            for (int i = 0; i < yArray.Length; i++)
            {
                var argument = yArray[i];
                result += Math.Pow(argument * Math.Cos(Math.Pow(argument * Math.PI / 180, 2)), 1.0 / 3.0);
                Console.Write(Math.Round(result, 2) + " | ");
            }

            Console.WriteLine("T1 complete");
        }
    }
}
