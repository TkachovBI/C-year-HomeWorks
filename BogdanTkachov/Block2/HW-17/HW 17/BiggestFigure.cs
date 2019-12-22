using System;

namespace HW_17
/* Описать сущность геметрическая фигура. Используйте инкапсуляцию, 
 * наследование,полиморфизм для описания, треугольника, четырехугольника, 
 * ромба и овала Создайте методы, вычисляющие периметр, площадь, радиус, если необходимо всех фигур.
 * Также напишите перегрузку операторов сравнения для выявления наибольшой фигуры по площадям, пеиметрам и т.д*/
{
    static class BiggestFigure
    {
        public static void TheBiggestSquareOfFigure(double square1, double square2)
        {
            Console.WriteLine("Max figgure, whitc perimeter is" + Math.Max(square1, square2));
        }

        public static void TheBiggestSquareOfFigure(double square1, double square2, double square3)
        {
            Console.WriteLine("Max figgure, whitc perimeter is" + Math.Max(square1, Math.Max(square2, square3)));
        }
        public static void TheBiggestSquareOfFigure(double square1, double square2, double square3, double square4)
        {
            Console.WriteLine("Max figgure, whitc perimeter is" + Math.Max(square1, Math.Max(square2, Math.Max(square3, square4))));
        }

        public static void TheBiggestPerimeterOfFigure(double square1, double square2, double square3, double square4)
        {
            Console.WriteLine("Max figgure, whitc perimeter is" + Math.Max(square1, Math.Max(square2, Math.Max(square3, square4))));
        }

        public static void TheBiggestPerimeterOfFigure(double square1, double square2)
        {
            Console.WriteLine("Max figgure, whitc perimeter is" + Math.Max(square1, square2));
        }

        public static void TheBiggestPerimeterOfFigure(double square1, double square2, double square3)
        {
            Console.WriteLine("Max figgure, whitc perimeter is" + Math.Max(square1, Math.Max(square2, square3)));
        }
    }
}
