namespace HW_17
{
    class Romb
    {
        private int numberOfSides;
        public double firstSide;
        

        public double Perimeter()
        {
            return 4 * (firstSide);
        }

        public double sqare(double h)
        {
            double temp = firstSide * h;
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
                numberOfSides = 4;
            }
        }
    }
}
