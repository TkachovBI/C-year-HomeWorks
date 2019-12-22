using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
            int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            Console.WriteLine("Зашифрованное число: " + encrypt);

            int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            Console.WriteLine("Расшифрованное число: " + decrypt);
        }

        public static void Task1()
        {
            /*Оператор сдвига влево <<
            Оператор << сдвигает левый операнд влево на количество битов, определенное правым операндом.
            Операция сдвига влево отбрасывает старшие биты, которые находятся за пределами диапазона типа результата,
            и задает позиции пустых битов низкого порядка, равные нулю, как показано в следующем примере: */

            uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");

            uint y = x << 4;
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
            // Output:
            // Before: 11001001000000000000000000010001
            // After:  10010000000000000000000100010000
        }

        public static void Task2()
        {
            /* Оператор сдвига вправо >>
            Оператор >> сдвигает левый операнд вправо на количество битов, определенное правым операндом.
            Операция сдвига вправо удаляет младшие разряды, как показано в следующем примере: */

            uint x = 0b_1001;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2),4}");

            uint y = x >> 2;
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2),4}");
            // Output:
            // Before: 1001
            // After:    10
        }

        public static void Task3()
        {
            /* Оператор ^ вычисляет побитовое логическое исключающее ИЛИ, также известное как побитовое логическое XOR, своих операндов: */

            uint a = 0b_1111_1000;
            uint b = 0b_0001_1100;
            uint c = a ^ b;
            Console.WriteLine(Convert.ToString(c, toBase: 2));
            // Output:
            // 11100100

            // Как вы думаете можно ли поменять значения двух переменных, при том что вы не используете третью переменную,
            //но при использовании исключающего или( ^ )?

            int x = 22;
            int z = 27;

            x ^= z;
            z ^= x;
            x ^= z;

            Console.WriteLine($"X: {x}, Z: {z}");
        }
    }
}
