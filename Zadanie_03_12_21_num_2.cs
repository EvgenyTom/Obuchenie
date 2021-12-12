using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        // Задание 2 Дата: 3 декабря
        // Составить программу для графического изображения делимости чисел от 1 до n (значение n вводится с клавиатуры). 
        // В каждой строке надо напечатать очередное число и столько символов «+», сколько делителей у этого числа. Например, если n = 4, то на экране должно быть напечатано:
        // 1+
        // 2++
        // 3++
        // 4+++
        
        int d = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= d; i++)
        {
            string deliteli = $"{i} ";
            
            for (int j = 1; j <= i; j++)
            { 
                if (i % j == 0)
                {
                    deliteli += "+";
                }
            }
            
            Console.WriteLine(deliteli);
        }
    }
}
