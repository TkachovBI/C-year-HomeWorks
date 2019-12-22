using System;
using System.Collections.Generic;

namespace HW7
{
    class Program
    {
        static void Main()
        {
            Task8();
        }

        public static void Task1()
        {
            // Вывести на экран все элементы второй строки массива
            int index1 = 10;
            int index2 = 10;
            int[,] array = new int[index1, index2];
            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = new Random().Next();
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int j = 0; j < index2; j++)
            {
                Console.WriteLine(array[1, j]);
            }
        }

        public static void Task2()
        {
            // С помощью генератора случайных значений создайте два массива. 
            // Выполните по отдельности сначала сложение, потом умножения массивов друг на друга.
            // Выведете исходные массивы и результат вычислений на экран

            int index1_1 = 10;
            int index1_2 = 10;
            int index2_1 = 11;
            int index2_2 = 12;
            int summ1 = 0;
            int summ2 = 0;
            int[,] array = new int[index1_1, index1_2];
            for (int i = 0; i < index1_1; i++)
            {
                for (int j = 0; j < index1_2; j++)
                {
                    array[i, j] = new Random().Next();
                    Console.Write(array[i, j] + "\t");
                    summ1 += array[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            int[,] array2 = new int[index2_1, index2_2];
            for (int i = 0; i < index2_1; i++)
            {
                for (int j = 0; j < index2_2; j++)
                {
                    array[i, j] = new Random().Next();
                    Console.Write(array[i, j] + "\t");
                    summ2 += array2[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(summ1 + summ2);
            Console.WriteLine(summ1 * summ2);
        }

        public static void Task3()
        {
            // Выясните есть ли одинаковые числа в массиве или же массив содержит только разные

            int index1 = 5;
            int index2 = 3;
            int[,] array = new int[index1, index2];

            Random random = new Random();

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = random.Next(0, index1 * index2);
                }
            }

            if (IsAlreadyInArray(array))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


        }

        private static bool IsAlreadyInArray(int[,] array)
        {
            List<int> doubles = new List<int>();
            List<int> list = new List<int>();

            foreach (int item in array)
            {
                if (list.Contains(item))
                {
                    doubles.Add(item);
                }
                else
                {
                    list.Add(item);
                }
            }

            return doubles.Count > 0;
        }

        public static void Task4()
        {
            // Сосчитайте количество различных чисел в массиве

            int index1 = 5;
            int index2 = 3;
            int[,] array = new int[index1, index2];
            int another = array.Length;

            Random random = new Random();

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = random.Next(0, index1 * index2);
                }
            }

            if (IsAlreadyInArray(array))
            {
                another--;
            }

            Console.WriteLine(another);
        }

        public static void Task5()
        {
            // Определите количество столбцов и количество строк массива, 
            // в которых не содержится ни одного отрицательного элемента. Выведите на экран найденные значения

            int index1 = 7;
            int index2 = 10;

            int A = 0;
            int B = 0;


            int[,] arr = new int[index1, index2];
            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = new Random().Next(-2, 9);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    if (arr[i, j] < 0) break;
                    else
                    {
                        if (j == index2 - 1)
                        {
                            A++;
                        }
                    }
                }
            }
            Console.WriteLine("неотрицательных строк " + A);


            for (int j = 0; j < index2; j++)
            {
                for (int i = 0; i < index1; i++)
                {
                    if (arr[i, j] < 0) break;
                    else
                    {
                        if (i == index1 - 1) B++;
                    }
                }
            }
            Console.WriteLine("неотрицательных столбцов " + B);
        }

        public static void Task6()
        {
            // Отсортируйте столбцы массива в порядке возрастания сумм их элементов

            int index1 = 5;
            int index2 = 5;
            int[,] array = new int[index1, index2];

            Random random = new Random();

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = random.Next(0, 1001);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] summ = new int[index1];
            int syze = summ.Length;
            int[] summ2 = new int[syze];

            for (int i = 0; i < summ.Length; i++)
            {
                summ[i] = 0;
            }

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    summ[i] += array[i, j];
                }
            }



            for (int i = 0; i < summ2.Length; i++)
            {
                summ2[i] = summ[i];
            }

            for (int i = 0; i < summ2.Length; i++)
            {
                for (int j = i + 1; j < summ2.Length; j++)
                {
                    if (summ2[i] > summ2[j])
                    {
                        int temp = summ2[i];
                        summ2[i] = summ2[j];
                        summ2[j] = temp;
                    }

                }
            }



            for (int j = 0; j < summ2.Length; j++)
            {
                for (int i = 0; i < summ2.Length; i++)
                {
                    if (summ2[j] == summ[i])
                    {
                        for (int s = 0; s < index2; s++)
                        {
                            Console.Write(array[i, s] + "\t");

                        }
                        goto res;
                    }
                }
            res:;
                Console.WriteLine();
            }



        }

        public static void Task7()
        {
            // Просуммируйте все элементы двумерного массива
            int index1 = 12;
            int index2 = 13;
            int[,] array = new int[index1, index2];
            int summ = 0;
            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = new Random().Next(0, 228);
                    Console.Write(array[i, j] + "\t");
                    summ += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine(summ);
        }

        public static void Task8()
        {
            // Заполните главные диагонали массива нулями

            int index1 = 12;
            int index2 = 12;
            int[,] array = new int[index1, index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = new Random().Next(1, 3);
                }
            }

            for (int i = 0; i < index1; i++)
            {
                for (int j = i; j == i; j++)
                {
                    array[i, j] = 0;
                }
            }
            int c = 0;
            int temp = index1 - 1;
            for (int i = temp; i >= 0; i--)
            {
                if (c < index2)
                {
                    array[i, c] = 0;
                }
                c++;
            }

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void Task9()
        {
            // Выведете на экран номера тех ячеек массива, в которых находятся отрицательные числа
            int index1 = 25;
            int index2 = 25;
            int[,] array = new int[index1, index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = new Random().Next(-100, 100);
                    if (array[i, j] < 0)
                    {
                        Console.WriteLine(i + "   " + j);
                    }
                }
            }
        }

        public static void Task10()
        {
            // Поменять максимальный и минимальный элемент массива местами

            int[] minXY = new int[2];
            int[] maxXY = new int[2];
            int index1 = 25;
            int index2 = 25;
            int min = int.MaxValue;
            int max = int.MinValue;
            int[,] array = new int[index1, index2];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    array[i, j] = new Random().Next(-100, 100);
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minXY[0] = i;
                        minXY[1] = j;
                    }
                    else if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxXY[0] = i;
                        maxXY[1] = j;
                    }
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            array[minXY[0], minXY[1]] ^= array[maxXY[0], maxXY[1]];
            array[maxXY[0], maxXY[1]] ^= array[minXY[0], minXY[1]];
            array[minXY[0], minXY[1]] ^= array[maxXY[0], maxXY[1]];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Task11()
        {
            // *Пользователь вводит число. Определить сумму всех элементов массива, которые больше заданного пользователем числа, если такое есть

            Console.Write("Write number: ");
            int r;
            bool isNum = int.TryParse(Console.ReadLine(), out r);
            if (isNum)
            {
                int summ = 0;
                int index1 = 25;
                int index2 = 25;
                int[,] array = new int[index1, index2];

                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        array[i, j] = new Random().Next(-100, 100);
                        if (array[i, j] > r)
                        {
                            summ += array[i, j];
                        }
                    }
                }
                Console.WriteLine($"Summ of numbers higher than {r}, is {summ}");
            }

        }
    }
}
