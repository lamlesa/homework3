using System;

namespace lab4
{
    public class Program
    {
        public static void Date(short x, short y)
        {
            if ((x < 1) || (x > 365))
                throw new Exception("Введённое значение не принадлежит диапазону .");
            else
            {
                DateTime day = new DateTime(y - 1, 12, 31, 0, 0, 0);
                DateTime answer = day.AddDays(x);
                Console.WriteLine(answer);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 4:");
            Console.Write("Введите число от 1 до 365 (потом нажмите Enter): ");
            short number;
            bool flag = short.TryParse(Console.ReadLine(), out number);
            while (!flag)
            {
                Console.Write("Введите число от 1 до 365 ещё раз: ");
                flag = short.TryParse(Console.ReadLine(), out number);
            }
            Console.Write("Введите порядковый номер года: ");
            short year;
            flag = short.TryParse(Console.ReadLine(), out year);
            while (!flag)
            {
                Console.Write("Введите год ещё раз: ");
                flag = short.TryParse(Console.ReadLine(), out year);
            }
            try
            {
                Date(number, year);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}