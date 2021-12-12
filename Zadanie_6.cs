using System;

namespace Zadaniy
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Задание 6
            // Первая строка содержит число n (1 ≤ n ≤ 100). Во второй строке записаны n целых чисел, каждое из которых не превышает по модулю 100. 
            int n;

            Console.Write("Введите число от 1 до 100 включительно: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i;
                Console.Write(array[i]);
            }

            Console.ReadLine();
        }
    }
}
