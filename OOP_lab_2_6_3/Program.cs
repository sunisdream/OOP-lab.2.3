using System;

namespace OOP_lab_2_6_3
{
    class Program
    {
        public static int NegativeCount(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int IndexOfMinAbs(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (Math.Abs(array[index]) >= Math.Abs(array[i]))
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = IndexOfMinAbs(array) + 1; i < array.Length; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main()
        {
            var random = new Random();

            int[] array = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("Kiлькiсть вiд’ємних елементiв масиву: {0}", NegativeCount(array));
            Console.WriteLine("Cумa елементiв масиву, розташованих пiсля мiнiмального за модулем елемента: {0}", Sum(array));
        }
    }
}
