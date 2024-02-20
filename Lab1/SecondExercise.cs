using System;
using System.Linq;
using System.Threading;

namespace Lab1
{

    public class SecondExercise
    {
        public static void StartThreading()
        {
            var defaultArray = CreateArray();

            var t0 = new Thread(() => ArraySum(defaultArray));
            var t1 = new Thread(() => ArrayProduct(defaultArray));

            t0.Start();
            t1.Start();

            t0.Join();
            t1.Join();
        }

        private static int[] CreateArray()
        {
            var array = new int[10];
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 26);
                Console.Write(array[i] + " | ");
            }

            Console.WriteLine();

            return array;
        }

        private static void ArraySum(int[] defaultArray) => Console.WriteLine("T0 start:\n" + defaultArray.Sum(x => x));

        private static void ArrayProduct(int[] defaultArray)
        {
            long product = 1;
            foreach(int num in defaultArray)
            {
                product *= num;
            }

            Console.WriteLine("T1 start:\n" + product);
        }
    }
}
