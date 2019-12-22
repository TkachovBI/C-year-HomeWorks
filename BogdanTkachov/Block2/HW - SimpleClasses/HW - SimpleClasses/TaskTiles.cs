using System;

namespace HW___SimpleClasses
{
    class Tiles
    {
        /* Создать класс Tiles (кафель)
          , который будет содержать поля с открытым доступом:
          brand, size_h, size_w, price и метод класса getData().
          В главной функции объявить пару объектов класса и внести данные в поля. Затем отобразить их, 
          вызвав метод getData().
       */

        public string brand;
        public double size_h;
        public double size_w;

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }
        public double Size_h
        {
            get
            {
                return size_h;
            }

            set
            {
                size_h = value;
            }
        }
        public double Size_w
        {
            get
            {
                return size_w;
            }

            set
            {
                size_w = value;
            }
        }

        public string getData()
        {
            string AllData;

            AllData = $"Brand is {brand}, and size are {size_h} high and {size_w} weight";

            return AllData;
        }
    }
            
    class Program
    {
       static void Main()
       {
            Tiles tile1 = new Tiles();
            tile1.Brand = "5ok";
            tile1.Size_h = 20.5; 
            tile1.Size_w = 20.5;

            Console.WriteLine(tile1.getData());

            Tiles tile2 = new Tiles();
            tile2.Brand = "fiasko";
            tile2.Size_h = 10.5;
            tile2.Size_w = 20.5;

            Console.WriteLine(tile1.getData());



        }

    }
    
}
