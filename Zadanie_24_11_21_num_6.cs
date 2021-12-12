using System;

namespace Zadaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 6  Дата: 24 ноября
            // Дана строка, заканчивающаяся точкой. Подсчитать, сколько слов в строке.
            
            string str = Console.ReadLine();
            int k = 0;
            
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ' || str[i] == '.')
                    k++;
                    
            Console.WriteLine(k);
        }
    }
}
