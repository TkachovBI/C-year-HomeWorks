using System;

namespace Third
{
    // 3. Создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию. 

    static class expansion
    {
        public static int[] SortArray(int[] array)
        {
            Array.Sort(array);
            return array;
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
