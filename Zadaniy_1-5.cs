using System;

class Program
{
    static void Main(string[] args)
    {
        //Задание 1
        //Console.Write("n = ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //for (int i = 1; i <= n; i++)
        //{
        //    sum += i;
        //}
        //Console.WriteLine("Сумма первых {0} членов арифметической прогрессии равна {1}", n, sum);
        //Console.ReadLine();

        //Задание 2
        //Console.Write("p = ");
        //int p = Convert.ToInt32(Console.ReadLine());
        //int i = p;
        //int factor = 1;
        //do
        //{
        //    factor = factor * i;
        //    --i;
        //}
        //while (i > 1);
        //Console.WriteLine($"{p}!= {factor}");
        //Console.ReadLine();

        //Задание 3: Посчитать количество и сумму парных чисел в диапазоне от 1 до N.
        //Console.Write("N = ");
        //int N = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //int count = 0;
        //for (int i = 1; i <= N; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        sum += i;
        //        count++;
        //    }
        //}
        //Console.WriteLine($"Колличество парных чисел в диапазоне от 1 до {N} равно {count}");
        //Console.WriteLine($"Сумма парных чисел в диапазоне от 1 до {N} равна {sum}");

        //Задание 4: Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m.
        //Console.Write("m = ");
        //int m = Convert.ToInt32(Console.ReadLine());
        //int k = m;
        //char b = '*';
        //for (int i = 0; i <= m; i++)
        //{
        //    for (int j = 0; j <= k; j++)
        //    {
        //        Console.Write(b);
        //    }
        //    Console.WriteLine();
        //    --k;
        //}

        //Задание 5: Используя вложенные циклы, вывести таблицы умножения от второй до шестой.
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 2; j <= 6; j++)
            {
                Console.Write(i * j);
                Console.Write("   ");
            }
            Console.WriteLine();
        }
    }
}
