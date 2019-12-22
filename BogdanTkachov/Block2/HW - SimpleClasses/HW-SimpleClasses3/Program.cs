using System;

namespace HW_SimpleClasses3
{

    class ArrayFlipper
    {
        /* Преобразовать строки двумерного массива в столбцы. Например было: 
11	22
33	44
55	66
77	88


стало:
11	33	55	77
22	44	66	88

Класс будет содержать два метода: один заполнит массив значениями, второй произведет замену значений строк на значения столбцов.*/

        int[,] aarray;
        int index1;
        int index2;

        public int[,] array(int min, int max)
        {

            aarray = new int[index1, index2];
            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    aarray[i, j] = new Random().Next(min, max);
                }
            }

            return aarray;
        }

        public int[,] flipedArray(int[,] aarray)
        {
            int[,] FlipedArray = new int[index2, index1];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    FlipedArray[j, i] = aarray[i, j]; 
                }
            }

            return FlipedArray;
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
