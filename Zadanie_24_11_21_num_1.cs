using System;

namespace Zadaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1  Дата: 24 ноября
            // Дана строка, содержащая русскоязычный текст. Найти количество слов, начинающихся с буквы "о".
            
            string str = Console.ReadLine();
            int k = 0;
            
            for (int i = 0; i < str.Length - 1; i++)
                if (i == 0 && (str[i] == 'о' || str[i] == 'О'))
                    k++;
                    
                else if ((str[i + 1] == 'о' || str[i + 1] == 'О') && str[i] == ' ')
                    k++;
                    
            Console.WriteLine(k);
        }
    }
}
