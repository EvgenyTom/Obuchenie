using System;

namespace Zadaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 8 Дата: 12 ноября
            // Задана последовательность целых чисел. Подсчитать количество элементов, у которых четные соседи.

            Console.WriteLine("Задайте количество элементов");
            int n = Convert.ToInt32(Console.ReadLine()), k = 0;
            int[] a = new int[n];

            Console.WriteLine("Задайте значения элементам");
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n - 1; i++)
                if (a[i - 1] % 2 == 0 && a[i + 1] % 2 == 0)
                    k++;

            Console.WriteLine("Количество элементов, у которых четные соседи: " + k);
        }
    }
}
