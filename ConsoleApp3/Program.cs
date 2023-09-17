using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
class Calculator
{
    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Subtract(double a, double b)
    {
        return a - b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static double Divide(double a, double b)
    {
        if (a == b)
        { }
        return a / b;
    }
    static double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }
    static double SquareRoot(double a)
    {
        if (a < 0)
        { }
        return Math.Sqrt(a);
    }
    static double Percent(double a)
    {
        return a / 100;
    }
    static double Factorial(double a)
    {
        if (a < 0)
        {
        }
        if (a == 0)
        { }
        double result = 1; for (int i = 1; i <= a; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию ");
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычитание ");
            Console.WriteLine("3.Умножение ");
            Console.WriteLine("4.Деление ");
            Console.WriteLine("5.Возвести в степень ");
            Console.WriteLine("6.Найти квадратный корень ");
            Console.WriteLine("7.Найти 1 процент от числа ");
            Console.WriteLine("8.Факториал");
            Console.WriteLine("9.Выйти из программы ");
            string choice = Console.ReadLine();
            if (choice == "9")
            {
                break;
            }
            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6" && choice != "7" && choice != "8")
            {
                Console.WriteLine("Неверный выбор. Пожалуйста выберите снова."); continue;
            }
            Console.Write("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());
            if (choice != "5" && choice != "6" && choice != "7" && choice != "8")
            {
                Console.Write("Введите второе число:");
                double num2 = double.Parse(Console.ReadLine());
                { }
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Результат:" + Add(num1, num2)); break;
                    case "2":
                        Console.WriteLine("Результат:" + Subtract(num1, num2)); break;
                    case "3":
                        Console.WriteLine("Результат:" + Multiply(num1, num2)); break;
                    case "4":
                        if (num2 == 0) Console.WriteLine("Деление на 0 невозможно");
                        else Console.WriteLine("Результат:" + Divide(num1, num2));
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case "5":
                        Console.Write("Введите степень:");
                        double n = double.Parse(Console.ReadLine()); Console.WriteLine("Результат:" + Power(num1, n));
                        break;
                    case "6":
                        if (num1 < 0) Console.WriteLine("Нельзя извлекать квадратный корень из отрицательного числа");
                        else Console.WriteLine("Результат:" + SquareRoot(num1));
                        break;
                    case "7":
                        Console.WriteLine("Результат:" + Percent(num1));
                        break;
                    case "8":
                        if (num1 < 0)
                            Console.WriteLine("нельзя вычислить факториал отрицательного числа");
                        else Console.WriteLine("Результат:" + Factorial(num1));
                        break;


                }
            }

        }
    }
}