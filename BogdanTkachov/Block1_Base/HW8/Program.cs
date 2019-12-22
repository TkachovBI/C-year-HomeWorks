using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Task1()
        {
            int index1 = 10;
            int index2 = 10;
            int[,] arr1 = new int[index1, index2];
            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr1[i, j] = new Random().Next(1, 5);
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = 0;
            string XY = "";

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    if (max < arr1[i, j])
                    {
                        max = arr1[i, j];
                        XY = $"Coords max element: {i + 1}, {j + 1}";
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(XY);
        }

        public static void Task2()
        {

            int index1 = 9;
            int index2 = 9;
            char[,] arr = new char[index1, index2];
            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = '.';
                    if (i == j | i + j == index1 - 1 | j == index2 / 2 | i == index1 / 2)
                    {
                        arr[i, j] = '*';
                    }
                    Console.Write(arr[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Task3()
        {
            int index1 = 5;
            int index2 = 5;

            int i = 0;
            int j = 0;
            int k = index1--;
            int tmp;

            int[,] arr = new int[index1, index2];
            for (int a = 0; a < index1; a++)
            {
                for (int b = 0; b < index2; b++)
                {
                    arr[a, b] = new Random().Next(10, 100);
                    Console.Write(arr[a, b] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();


            while (i < 5)
            {
                tmp = arr[i, j];
                arr[i, j] = arr[i, k];
                arr[i, k] = tmp;
                i++; j++; k--;
            }

            for (int z = 0; z < index1; z++)
            {
                for (int l = 0; l < index1; l++)
                {
                    Console.Write(arr[z, l] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Task4()
        {

            int index1 = 6;
            int index2 = 5;

            int[,] array = new int[index1, index2];
            int[,] array2 = new int[index2, index1];

            for (int a = 0; a < index1; a++)
            {
                for (int b = 0; b < index2; b++)
                {
                    array[a, b] = new Random().Next(10, 100);
                    Console.Write(array[a, b] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int k = 0; k < index2; k++)
            {
                for (int c = 0; c < index1; c++)
                {
                    array2[k, c] = array[index1 - c - 1, k];
                    Console.Write(array2[k, c] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

    }
}


