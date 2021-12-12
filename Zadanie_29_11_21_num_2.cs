using System;

namespace Zadaniy
{
    class Program
    {
        // Задание 2     Дата 29 ноября 
        /* 2) Выполнить: Необходимо переделать предыдущую задачу, теперь функция периметр должна возвращать целое значение. 
        Напомним задание: Вводятся три числа — длины трех сторон треугольника. 
        Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
        Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
        Указание 2: Метод должен возвращать значение типа integer, поэтому вы должны использовать ключевое слово int в сигнатуре:
        static int Perimeter(...);
        Указание 3: Не забудьте преобразовать введенные значения в целые числа. Например:
        int a = int.Parse(Console.ReadLine());
            
        Пример выполнения:
        Введите значения для трех сторон треугольника:
        3 5 6
        Периметр: 14
        */
        
        
        static int Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }
        
       static void Main(string[] args)
       {
            Console.WriteLine("Задайте значения сторон треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр: " + Perimeter(a, b, c));
       }
    }
}
