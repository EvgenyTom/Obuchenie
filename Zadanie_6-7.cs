using System;
class Program
{
    public static void Main(string[] args)
    {
        // Задание 6
        // Первая строка содержит число n (1 ≤ n ≤ 100). Во второй строке записаны n целых чисел, каждое из которых не превышает по модулю 100. 

        var n = Convert.ToInt32(Console.ReadLine());
        var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int max = array[0];

        for (int a = 1; a < array.Length; a++)
        {
            if (max < array[a])
            {
                max = array[a];
            }
        }

        Console.WriteLine(max);

        // Задание 7
        //В первой строке записано число N. В следующей строке N целых чисел. Все числа не превышают 100.

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
