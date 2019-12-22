using System;

namespace TaskWithPrice
{
    class price
    {
        /* 3. Определить класс с именем Price, содержащий следующие поля:
    - название товара;
    - название магазина, в котором продается товар;
    - стоимость товара в грн.
    Методы:
    - ввод данных в массив из n элементов в типа Price;
    - упорядочить в алфавитном порядке по названиям товаров;
    - вывод информации о товаре, название которого ввел пользователь.*/

        public string Name;
        public string ShopName;
        public double PriceOfThem;

        public price(string Name, string ShopName, double PriceOfThem)
        {
            this.Name = Name;
            this.ShopName = ShopName;
            this.PriceOfThem = PriceOfThem;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*  - ввод данных в массив из n элементов в типа Price;
    - упорядочить в алфавитном порядке по названиям товаров;
    - вывод информации о товаре, название которого ввел пользователь.*/

            price chocolate1 = new price("Chocolate Milca", "Magnit", 99.99);
            price chocolate2 = new price("Chocolate Roshen", "Ashan", 999.99);
            price chocolate3 = new price("Chocolate Millenium", "ATB", 59.99);

            string[] Names = { chocolate1.Name, chocolate2.Name, chocolate3.Name };

            string[] NamesSort = { chocolate1.Name, chocolate2.Name, chocolate3.Name };
            Array.Sort(NamesSort);

            foreach (var item in NamesSort)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            string Product;
            Console.Write("Please, write name of product");
            Product = Console.ReadLine();

            switch (Product)
            {
                case "Chocolate Milca":
                    Console.Write($"{chocolate1.Name} is in the {chocolate1.ShopName} and coast {chocolate1.PriceOfThem}");
                    break;

                case "Chocolate Roshen":
                    Console.Write($"{chocolate2.Name} is in the {chocolate2.ShopName} and coast {chocolate2.PriceOfThem}");
                    break;

                case "Chocolate Millenium":
                    Console.Write($"{chocolate3.Name} is in the {chocolate3.ShopName} and coast {chocolate3.PriceOfThem}");
                    break;

                default:
                    Console.WriteLine("We have not this product is the base");
                    break;
            }
        }
    }
}
