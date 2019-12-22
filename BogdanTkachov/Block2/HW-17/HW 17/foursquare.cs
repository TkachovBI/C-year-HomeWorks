namespace HW_17
{
    class foursquare
    {
        private int numberOfSides;
        public double firstSide;
        public double secondSide;

        public double Perimeter()
        {
            return 2 * (firstSide + secondSide);
        }

        public double sqare()
        {
            double temp = (Perimeter() / 4.0) * (Perimeter() / 4.0);
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
