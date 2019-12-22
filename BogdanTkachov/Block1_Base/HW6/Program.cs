using System;
using System.Collections.Generic;

namespace HW7
{
    class Program
    {
        static void Main()
        {
            Task3();
        }

        public static void Task1()
        {
            // Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы. 

            int[] arr = new int[10];
            int i = 0;

            Console.Write("Please, write first Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write second Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write third Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write fourth Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write fifth Number: ");
            arr[i++] = int.Parse(Console.ReadLine()); Console.Write("Please, write first Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write sixth Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write seventh Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write eighth Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write ninth Number: ");
            arr[i++] = int.Parse(Console.ReadLine());

            Console.Write("Please, write tenth Number: ");
            arr[i] = int.Parse(Console.ReadLine());

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine();
        }

        public static void Task2()
        {
            // Заполнить массив из пятнадцати элементов случайным образом:
            // а) вещественными значениями, лежащими в диапазоне от 0 до 1;
            // б) вещественными значениями х (22 х < 23);
            // в) вещественными значениями х (0 х < 10);
            // г) вещественными значениями х (–50 х < 50);
            // д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.

            #region a
            {
                Console.WriteLine("Двоичная система)");

                double[] arr = new double[15];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().NextDouble();
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion

            #region b
            {
                double[] arr = new double[15];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().NextDouble();
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }


            }
            #endregion

            #region c 
            {
                double[] arr = new double[15];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().NextDouble();
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion

            #region d
            {
                double[] arr = new double[15];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().NextDouble();
                }
            

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion

            #region e
            {
                int[] arr = new int[15];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 11);
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion
        }

        public static void Task3()
        {
            // Используя датчик случайных чисел, заполнить массив из двадцати элементов неповторяющимися числами

            int syze = 20;
            int[] array = new int[syze];
            int max = 20;
            int min = 0;
            if (max - min - 1 != array.Length)
            {
                array[0] = new Random().Next(min, max);
                for (int i = 1; i < syze; i++)
                {
                    array[i] = new Random().Next(min, max);
                    if (!IsNotSame(array, i))
                    {
                        i--;
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static bool IsNotSame(int[] arr, int now)
        {
            int count = 0;
            for (int i = 0; i <= now; i++)
            {
                for (int j = 0; j <= now; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                }
            }


            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Task4()
        {
            // Дан массив. Все его элементы:а) увеличить в 2 раза;б) уменьшить на число А;в) разделить на первый элемент.

            # region a
            {
                int syze = 25;

                int max = 50;

                int[] array = new int[syze];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(0, max);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] *= 2;
                }
            }
            #endregion

            # region b
            {
                int A = 3;

                int syze = 25;

                int max = 50;

                int[] array = new int[syze];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(0, max);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] -= A;
                }
            }
            #endregion

            # region c
            {
                int syze = 25;

                int max = 50;

                int[] array = new int[syze];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(0, max);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] /= array[0];
                }
            }
            #endregion
        }

        public static void Task5()
        {
            // В массиве хранятся сведения о стоимости 12 различных предметов. Определить общую стоимость всех предметов.

            int[] price = new int[12];

            int summ = 0;

            for (int i = 0; i < price.Length; i++)
            {
                price[i] = new Random().Next(0, 500);
                summ += price[i];
            }

            Console.WriteLine("Summ is: " + summ);
        }

        public static void Task6()
        {
            //Дан массив целых чисел. Выяснить:
            // а) верно ли, что сумма элементов массива есть четное число;
            // б) верно ли, что сумма квадратов элементов массива есть пятизначное число.

            int[] array = new int[25];
            int summ = 0;
            int summSec = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 1001);
                summ += array[i];
                summSec += (array[i] * array[i]);
            }

            if (summ % 2 == 0)
            {
                Console.WriteLine("четное число");
            }
            else
            {
                Console.WriteLine("neчетное число");
            }

            string str = summSec.ToString();

            if (str.Length == 5)
            {
                Console.WriteLine("сумма квадратов элементов массива есть пятизначное число");
            }
            else
            {
                Console.WriteLine("сумма квадратов элементов массива ne есть пятизначное число");
            }

        }

        public static void Task7()
        {
            // Дан массив. Напечатать:а) все неотрицательные элементы;б) все элементы, не превышающие число 100.

            #region a 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion

            #region b 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 100)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion


        }

        public static void Task8()
        {
            // Дан массив целых чисел. Напечатать:а) все четные элементы;б) все элементы, оканчивающиеся нулем

            #region a 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion

            #region b 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 10 == 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion
        }

        public static void Task9()
        {
            // Дан массив. Вывести на экран сначала его неотрицательные элементы, затем отрицательные.

            #region a 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion

            #region b 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion
        }

        public static void Task10()
        {
            // Дан массив. Вывести на экран сначала его элементы, стоящие на четных местах, затем — на нечетных
            #region a 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion

            #region b 
            {
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            #endregion
        }

        public static void Task11()
        {
            // Дан массив. Найти:а) сумму элементов массива, значение которых не превышает 20;б) сумму элементов массива, больших числа a

            #region a 
            {
                int summ = 0;
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 20)
                    {
                        summ += array[i];
                    }
                }
                Console.WriteLine(summ);
            }
            #endregion

            #region b 
            {
                int a = 25;
                int summ = 0;
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < a)
                    {
                        summ += array[i];
                    }
                }
                Console.WriteLine(summ);
            }
            #endregion
        }

        public static void Task12()
        {
            // Дан массив целых чисел. Найти:а) сумму нечетных элементов;
            // б) сумму элементов, кратных заданному числу;в) сумму элементов массива, кратных a или b

            #region a 
            {
                int summ = 0;
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        summ += array[i];
                    }
                }
                Console.WriteLine(summ);
            }
            #endregion

            #region b 
            {
                int a = 25;
                int summ = 0;
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % a == 0)
                    {
                        summ += 10;
                    }
                }
                Console.WriteLine(summ);
            }
            #endregion

            #region b 
            {
                int a = 25;
                int b = 13;
                int summ = 0;
                int[] array = new int[25];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(-500, 500);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % a == 0 || array[i] % b == 0)
                    {
                        summ += 10;
                    }
                }
                Console.WriteLine(summ);
            }
            #endregion
        }

        public static void Task13()
        {
            // Определить сумму второго, четвертого, шестого и т. д. элементов массива.

            int[] array = new int[99];
            int summ = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                summ += array[i];
            }
            Console.WriteLine(summ);
        }

        public static void Task14()
        {
            int syze = 228;
            int[] array = new int[syze];
            Console.WriteLine((array.Length - 1) / 2);
        }

        public static void Task15()
        {
            // Рост каждого из 22 учеников класса представлен в виде массива. Определить количество учеников, рост которых не превышает значения r

            int r = 170;
            int count = 0;
            int[] array = new int[22];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(101, 229);
                if (array[i] < r)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}



