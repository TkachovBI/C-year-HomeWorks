using System;

namespace First
// 1. Создать статический класс Calculator, с методами для выполнения основных арифметических операций. 
// Написать программу, которая выводит на экран основные арифметические операции. 
{
    static class Calculator
    {
        public static double Pluss(double first, double second)
        {
            return (first + second);
        }

        public static double Minus(double first, double second)
        {
            return (first * second);
        }

        public static double Proi(double first, double second)
        {
            return (first + second);
        }
        public static double Del(double first, double second)
        {
            return (first / second);
        }

        public static double Prosent(double first, double second)
        {
            return (first % second);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int d = 2;

            Console.WriteLine(Calculator.Del(i,d));
            Console.WriteLine(Calculator.Pluss(i, d));
            Console.WriteLine(Calculator.Minus(i, d));
            Console.WriteLine(Calculator.Proi(i, d));
            Console.WriteLine(Calculator.Prosent(i, d));
        }
    }
}
