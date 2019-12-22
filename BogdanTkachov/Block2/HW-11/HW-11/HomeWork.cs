using System;

namespace HW_11
{
    class Rectengel
    {
        /* Создать класс с именем Rectangle, содержащий следующие поля:
    - два поля, описывающие длины сторон double side1, side2.
    - создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов
    Методы
    - вычисление площади прямоугольника - double AreaCalculator()
    - периметр прямоугольника - double PerimeterCalculator()
    - Создать два свойства double Area и double Perimeter с одним методом доступа get
    - Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.*/

        public double side1;
        public double side2;

        private double area;
        private double perimeter;

        public double Area
        {
            get
            {
                return area;
            }

            private set
            {
                area = AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return perimeter;
            }

            private set
            {
                perimeter = PerimeterCalculator();
            }
        }
        public Rectengel(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

    }   

    class Program
    {
        static void Main(string[] args)
        {

            
        }

        static void TaskWithRectengel()
        {
            double side1;
            double side2;

            Console.Write("Hello, please, write side 1: ");
            bool isDouble = double.TryParse(Console.ReadLine(), out side1);

            Console.Write("Hello, please, write side 2: ");
            bool isDouble2 = double.TryParse(Console.ReadLine(), out side2);

            if (isDouble && isDouble2)
            {
                Rectengel rectengel = new Rectengel(side1, side2);
                Console.WriteLine($"Perimeter: {rectengel.Perimeter}");
                Console.WriteLine($"Area: {rectengel.Area}");
            }
        }

       /* static void TaskWithOrder()
        {
            Console.WriteLine("Number Of Card (sender) 1");
            decimal NumberOfCard1Send = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Poluchatel");
            decimal Poluch1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Write summ in UAN");
            double SumHrn1 = double.Parse(Console.ReadLine());
            double sum1 = SumHrn1;



            

            Order ord = new Order(sum1, sum2, sum3);
            Poradok(sum1, sum2, sum3);

            Console.WriteLine("Введите сумму в грн: ");
            decimal sumPolz = Convert.ToDecimal(Console.ReadLine());

            decimal[] plat = new decimal[3];
            plat[0] = Platil1;
            plat[1] = Platil2;
            plat[2] = Platil3;

            decimal[] poluch = new decimal[3];
            poluch[0] = Poluch1;
            poluch[1] = Poluch2;
            poluch[2] = Poluch3;

            decimal[] HRN = new decimal[3];
            HRN[0] = SumHrn1;
            HRN[1] = SumHrn2;
            HRN[2] = SumHrn3;

            decimal[] Evro = new decimal[3];
            Evro[0] = SumEvro1;
            Evro[1] = SumEvro2;
            Evro[2] = SumEvro3;

            decimal[] Dollars = new decimal[3];
            Dollars[0] = SumDollar1;
            Dollars[1] = SumDollar2;
            Dollars[2] = SumDollar3;

            decimal[] sravnenie = new decimal[3];
            sravnenie[0] = sum1;
            sravnenie[1] = sum2;
            sravnenie[2] = sum3;
            Console.WriteLine("Информация о платильщиках, чья сумма больше " + sumPolz);*/
        //}
    }
}
