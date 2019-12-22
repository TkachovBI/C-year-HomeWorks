using System;

namespace HW_17
{

    class Oval
    {
        private int numberOfSides;
        public double firstSide;
        public double secondSide;

        public double Perimeter()
        {
            return 0;
        }

        public double sqare(double small, double big)
        {
            double temp = Math.PI * small * big;
            return temp;
        }

        public int CountOfSides
        {
            get
            {
                return numberOfSides;
            }

            set
            {
                numberOfSides = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
