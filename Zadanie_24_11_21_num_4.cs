using System;

namespace Zadaniy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4  Дата: 24 ноября
            // В строке заменить букву(а) буквой (о). Подсчитать количество замен. Подсчитать, сколько символов в строке.
            
            string str = Console.ReadLine();
            int k = 0;
            str = str.Replace("а", "о");
            
            for (int i = 0; i < str.Length; i++)
                if (str[i] == 'о')
                    k++;
                    
            Console.WriteLine(k);
        }
    }
}
