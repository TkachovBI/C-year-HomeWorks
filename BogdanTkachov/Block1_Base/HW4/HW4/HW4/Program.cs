using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void HW1()
        {
            // Дано целое число.Если оно является положительным, то прибавить к нему 1; если отрицательным, 
            // то вычесть из него 2; если нулевым, то заменить его на 10.Вывести полученное число.​
            int number = 0;
            if (number > 0)
            {
                Console.WriteLine(++number);
            }
            else if (0 > number)
            {
                Console.WriteLine(number - 2);
            }
            else
            {
                number = 10;
                Console.WriteLine(number);
            }
        }
        public static void HW2()
        {

            // Даны три целых числа. Найти количество положительных чисел в исходном наборе​
            int first = -15;
            int second = 15;
            int third = 0;
            int plus = 0;
            if (first > 0)
            {
                plus++;
            }
            if (second > 0)
            {
                plus++;
            }
            if (third > 0)
            {
                plus++;
            }
            Console.WriteLine(plus);
        }
        public static void HW3()
        {

            // Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.
            int first = -15;
            int second = 15;
            int third = 0;
            int plus = 0;
            int min = 0;
            if (first > 0)
            {
                plus++;
            }
            else if (first < 0)
            {
                min++;
            }
            if (second > 0)
            {
                plus++;
            }
            else if (second < 0)
            {
                min++;
            }
            if (third > 0)
            {
                plus++;
            }
            else if (third < 0)
            {
                min++;
            }
            Console.WriteLine(plus + "   " + min);
        }
        public static void HW4()

        {

            // Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной сумму этих значений, 
            // а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.
            int a;
            Console.WriteLine("Please write a");
            bool isNumber1 = int.TryParse(Console.ReadLine(), out a);
            int b;
            Console.WriteLine("Please write b");
            bool isNumber2 = int.TryParse(Console.ReadLine(), out b);
            if (isNumber1 && isNumber2)
            {
                if (a != b)
                {
                    a += b;
                    b = a;
                }
                else
                {
                    a = 0;
                    b = 0;
                }
            }
            else
            {
                Console.WriteLine("Error 404");
            }
            Console.WriteLine($"a: {a}, b:{b}");


        }
        public static void HW5()
        {

            // Напишите программу, проверяющую число на четность.​
            int number;
            Console.WriteLine("Please write a");
            bool isNumber = int.TryParse(Console.ReadLine(), out number);

            int number2;
            Console.WriteLine("Please write b");
            bool isNumber2 = int.TryParse(Console.ReadLine(), out number2);
            if (isNumber && isNumber2)
            {
                if (number % number2 == 0)
                {
                    Console.WriteLine("А кратное б");
                }
                else
                {
                    Console.WriteLine("а некратное б");
                }
            }


        }
        public static void HW6()
        {

            // Единицы длины пронумерованы следующим образом: 
            // 1 — дециметр,  2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр. Дан номер единицы длины (целое число в диапазоне 1–5)
            // и длина отрезка в этих единицах (вещественное число). Найти длину отрезка в метрах. ​
            string velue = "4";      // 1 — дециметр,  2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр
            float laight = 2.15f;
            switch (velue)
            {
                case "1":
                    Console.WriteLine(laight / 10);
                    break;

                case "2":
                    Console.WriteLine(laight * 1000);
                    break;

                case "3":
                    Console.WriteLine(laight);
                    break;

                case "4":
                    Console.WriteLine(laight / 1000);
                    break;

                case "5":
                    Console.WriteLine(laight / 100);
                    break;

                default:
                    Console.WriteLine(laight);
                    break;
            }

        }
        public static void HW7()
        {

            // Робот может перемещаться в четырех направлениях(«С» — север,  «З» — запад, «Ю» — юг, «В» — восток)
            // и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо.
            // Дан символ C — исходное направление робота и целое число N — посланная ему команда.Вывести направление робота после выполнения полученной команды.​
            Console.WriteLine("Write f where is robot («С» — север,  «З» — запад, «Ю» — юг, «В» — восток)");
            string C = Console.ReadLine();
            Console.WriteLine("Write a command(0 — продолжать движение, 1 — поворот налево, –2 — поворот направо");
            int N = int.Parse(Console.ReadLine());   //0 — продолжать движение, 1 — поворот налево, –2 — поворот направо
            
           
            switch (C)
            {
                case "С":
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("север");
                            break;

                        case 1:
                            Console.WriteLine("запад");
                            break;

                        case 2:
                            Console.WriteLine("восток");
                            break;

                        default:
                            Console.WriteLine("WE don\'t know this command");
                            break;
                    }
                    break;

                case "З":
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("запад");
                            break;

                        case 1:
                            Console.WriteLine("юг");
                            break;

                        case 2:
                            Console.WriteLine("север");
                            break;

                        default:
                            Console.WriteLine("WE don\'t know this command");
                            break;
                    }
                    break;

                case "Ю":
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("юг");
                            break;

                        case 1:
                            Console.WriteLine("восток");
                            break;

                        case 2:
                            Console.WriteLine("запад");
                            break;

                        default:
                            Console.WriteLine("WE don\'t know this command");
                            break;
                    }
                    break;

                case "В":
                    switch (N)
                    {
                        case 0 :
                            Console.WriteLine("восток");
                            break;

                        case 1 :
                            Console.WriteLine("север");
                            break;

                        case 2 :
                            Console.WriteLine("юг");
                            break;

                        default:
                            Console.WriteLine("WE don\'t know this command");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("I don\'t noe this way");
                    break;
            }
        }
        public static void HW8()
        {

            // Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
            // Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
            // например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год»
            var years = new Random().Next(20, 70);

            var ones = years % 10;

            switch (ones)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(years + "лет");
                    break;

                case 1:
                    Console.WriteLine(years + "год");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine(years + "года");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        }
}
