namespace HW_17
{
    /* Описать сущность геметрическая фигура. Используйте инкапсуляцию, 
     * наследование,полиморфизм для описания, треугольника, четырехугольника, 
     * ромба и овала Создайте методы, вычисляющие периметр, площадь, радиус, если необходимо всех фигур.
     * Также напишите перегрузку операторов сравнения для выявления наибольшой фигуры по площадям, пеиметрам и т.д*/

    public class triangle : GeometricFiigure
    {
        private int numberOfSides;
        public double firstSide;
        public double secondSide;
        public double thirdSide;
        public double Perimeter()
        {
            return (firstSide + secondSide + thirdSide);
        }

        public int CountOfSides
        {
            get
            {
                return numberOfSides;
            }

            set
            {
                numberOfSides = 3;
            }
        }
    }
}
