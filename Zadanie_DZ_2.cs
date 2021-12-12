using System;

namespace Zadaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашнее задание Дата: 12 ноября
            //Задан массив из n целых чисел. Вывести только его положительные элементы, не меняя первоначальный порядок.
            
            Console.WriteLine("Задайте количество элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            
            Console.WriteLine("Задайте значения элементов");
            
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Положительные элементы: ");
            
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                    Console.WriteLine(a[i]);
        }
    }
}
