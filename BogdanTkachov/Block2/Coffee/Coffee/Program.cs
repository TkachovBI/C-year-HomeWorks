using System;

namespace Coffee
{

    class CoffeeMaker
    {
        private int totalvalueOfWater = 1000;
        private int totalcountOfSeed = 50;
        private int totalvalueOfMilk = 750;
        private int totalvalueOfSugare = 250;




        private int valueOfWater;
        private int countOfSeed;
        private bool isOn = true;
        private int valueOfMilk;
        private int valueOfSugare;




        public int ValueOfWater { get => valueOfWater; }
        public int CountOfSeed { get => countOfSeed; }
        public int ValueOfMilk { get => valueOfMilk; }
        public int ValueOfSugare { get => valueOfSugare; }
        public bool IsOn { get => isOn; set => isOn = value; }



        public void MakeCoffe(string coffee)
        {
            Console.WriteLine($"Before: Water {totalvalueOfWater}, sugare {totalvalueOfSugare}," +
                           $" seed {totalcountOfSeed}, milk {totalvalueOfMilk}");
            Console.WriteLine();

            if (IsOn)
            {
                switch (coffee)
                {
                    case "americano":

                        valueOfWater = 120;
                        valueOfSugare = 10;
                        countOfSeed = 5;
                        valueOfMilk = 0;

                        Console.WriteLine("Классический американо или хотите что-то добавить? классический или добавить)");
                        string AddToAmericano = Console.ReadLine().ToLower(); ;

                        if (AddToAmericano == "добавить")
                        {
                            Console.WriteLine("Что вы хоите добавить в кофе?(Сахар, молоко, вода, кофеин)");

                            string WhatAdd = Console.ReadLine().ToLower();

                            switch (WhatAdd)
                            {
                                case "сахар":
                                    Console.WriteLine("Сколько сахара добавить в кофе?");
                                    valueOfSugare += int.Parse(Console.ReadLine());
                                    break;

                                case "молоко":
                                    Console.WriteLine("Сколько молока добавить в кофе?");
                                    valueOfMilk += int.Parse(Console.ReadLine());
                                    break;

                                case "вода":
                                    Console.WriteLine("Сколько воды добавить в кофе?");
                                    valueOfWater += int.Parse(Console.ReadLine());
                                    break;

                                case "кофеин":
                                    Console.WriteLine("Сколько кофеина добавить в кофе?");
                                    countOfSeed += int.Parse(Console.ReadLine());
                                    break;

                                default:
                                    Console.WriteLine("Такого варианта нет");
                                    break;

                            }
                        }


                        if (totalvalueOfWater >= valueOfWater && totalvalueOfSugare >= valueOfSugare && totalcountOfSeed >= countOfSeed)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalvalueOfSugare -= valueOfSugare;
                            totalcountOfSeed -= CountOfSeed;
                            Console.WriteLine($"Ваш кофе говов");
                        }

                        if (totalvalueOfWater < valueOfWater)
                            Console.WriteLine("Вода закончилась");

                        if (totalvalueOfSugare < valueOfSugare)
                            Console.WriteLine("Сахар закончился");

                        if (totalcountOfSeed < countOfSeed)
                            Console.WriteLine("Зерна коффе закончились");
                        break;


                    case "latte":

                        Console.WriteLine("Какой латте желаете: европейский (200мл) или американский(500мл)?");
                        string WhatLatte = Console.ReadLine();
                        switch (WhatLatte)
                        {
                            case "европейский":
                                valueOfWater = 60;
                                valueOfMilk = 120;
                                break;

                            case "американский":
                                valueOfWater = 120;
                                valueOfMilk = 360;
                                break;

                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }

                        valueOfSugare = 20;
                        countOfSeed = 5;

                        if (totalvalueOfWater >= valueOfWater && totalvalueOfSugare >= valueOfSugare && totalcountOfSeed >= countOfSeed & totalvalueOfMilk >= valueOfMilk)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalvalueOfSugare -= valueOfSugare;
                            totalcountOfSeed -= CountOfSeed;
                            totalvalueOfMilk -= valueOfMilk;
                            Console.WriteLine($"Ваш кофе");
                        }

                        if (totalvalueOfWater < valueOfWater)
                            Console.WriteLine("Вода закончилась");

                        if (totalvalueOfSugare < valueOfSugare)
                            Console.WriteLine("Сахар закончился");

                        if (totalcountOfSeed < countOfSeed)
                            Console.WriteLine("Зерна коффе закончились");

                        if (totalvalueOfMilk < valueOfMilk)
                            Console.WriteLine("молоко закончилось");
                        break;



                    case "espresso":

                        Console.WriteLine("Какой эспрессо вы хотите? simple or double");
                        string whatEspreso = Console.ReadLine().ToLower();

                        valueOfWater = 30;

                        switch (whatEspreso)
                        {
                            case "simple":
                                valueOfSugare = 10;
                                countOfSeed = 7;
                                break;

                            case "double":
                                valueOfSugare = 10;
                                countOfSeed = 15;
                                break;

                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }

                        if (totalvalueOfWater >= valueOfWater && totalvalueOfSugare >= valueOfSugare && totalcountOfSeed >= countOfSeed)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalvalueOfSugare -= valueOfSugare;
                            totalcountOfSeed -= CountOfSeed;
                            Console.WriteLine($"Ваш кофе говов");
                        }

                        if (totalvalueOfWater < valueOfWater)
                            Console.WriteLine("Вода закончилась");

                        if (totalvalueOfSugare < valueOfSugare)
                            Console.WriteLine("Сахар закончился");


                        if (totalcountOfSeed < countOfSeed)
                            Console.WriteLine("Зерна коффе закончились");
                        break;


                    case "capucino":

                        valueOfSugare = 0;
                        valueOfWater = 100;
                        valueOfMilk = 50;
                        countOfSeed = 5;

                        Console.WriteLine("Классический капучино или хотите что-то добавить? классический, добавить");
                        string AddToCapucino = Console.ReadLine().ToLower();

                        if (AddToCapucino == "добавить")
                        {
                            Console.WriteLine("Что вы хоите добавить?(Сахар, молоко, вода, зерна кофе)");
                            string WhatAdd = Console.ReadLine().ToLower();
                            switch (WhatAdd)
                            {
                                case "сахар":
                                    Console.WriteLine("Сколько сахара добавить?");
                                    valueOfSugare += int.Parse(Console.ReadLine());
                                    break;
                                case "молоко":
                                    Console.WriteLine("Сколько молока добавить?");
                                    valueOfMilk += int.Parse(Console.ReadLine());
                                    break;
                                case "вода":
                                    Console.WriteLine("Сколько воды добавить?");
                                    valueOfWater += int.Parse(Console.ReadLine());
                                    break;
                                case "зерна кофе":
                                    Console.WriteLine("Сколько зерен кофе добавить?");
                                    countOfSeed += int.Parse(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Такого варианта нет");
                                    break;
                            }
                        }

                        if (totalvalueOfWater >= valueOfWater && totalvalueOfSugare >= valueOfSugare && totalcountOfSeed >= countOfSeed && totalvalueOfMilk >= valueOfMilk)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalcountOfSeed -= CountOfSeed;
                            totalvalueOfMilk -= valueOfMilk;
                            totalvalueOfSugare -= valueOfSugare;
                            Console.WriteLine($"Ваш кофе говов");
                        }
                        else
                        {
                            if (totalvalueOfWater <= 0)
                                Console.WriteLine("Вода закончилась");

                            if (totalcountOfSeed <= 0)
                                Console.WriteLine("Зерна коффе закончились");

                            if (totalvalueOfSugare <= 0)
                                Console.WriteLine("Сахар закончился");

                            if (totalvalueOfMilk <= 0)
                                Console.WriteLine("молоко закончилось");
                        }

                        break;

                    default:
                        Console.WriteLine("it isn\'t correct, try again (reload the program)");                        
                        break;

                        
                }

                Console.WriteLine();
                Console.WriteLine($"After: Water {totalvalueOfWater}, sugare {totalvalueOfSugare}," +
                          $" seed {totalcountOfSeed}, milk {totalvalueOfMilk}");

            }
        }
    }



    class Program
    {
        static void Main()
        {
            Console.WriteLine("Какой коффе: americano, latte, espresso, capucino");

            string coffee = Console.ReadLine().ToLower();
            Console.WriteLine();

            CoffeeMaker coffeeMaker = new CoffeeMaker();
            coffeeMaker.MakeCoffe(coffee);

        }
    }
}
