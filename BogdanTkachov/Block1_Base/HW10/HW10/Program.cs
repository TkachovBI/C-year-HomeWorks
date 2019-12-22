using System;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Task1()
        {
            // Составить программу обмена значениями трех переменных величин а, b, c строкового типа по следующей схеме:
            // а) b присвоить значение c, а присвоить значение b, c присвоить значение а;
            // б) b присвоить значение а, с присвоить значение b, а присвоить значение c​

            string a = "Hello";
            string b = "from";
            string c = "Egypt";

            string[] temp = new string[3];

            temp[0] = a;
            temp[1] = b;
            temp[2] = c;

            Console.WriteLine($"{a} {b} {c}");

            // A

            b = temp[2];
            a = temp[1];
            c = temp[0];

            Console.WriteLine($"{a} {b} {c}");

            Console.WriteLine();

            // B

            b = temp[0];
            a = temp[2];
            c = temp[1];

            Console.WriteLine($"{a} {b} {c}");

        }

        public static void Task2()
        {
            // Дано слово. Верно ли, что оно начинается и оканчивается на одну и ту же  букву?​

            string word = "faigh";
            char[] wordInChar = word.ToCharArray();
            if (wordInChar[0] == wordInChar[wordInChar.Length - 1])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public static void Task3()
        {
            // Даны два слова. Верно ли, что первое слово начинается на ту же букву, на которую заканчивается второе слово? ​

            string firstWord = "faigh";
            char[] firstWordInChar = firstWord.ToCharArray();

            string secondWord = "world";
            char[] secondWordInChar = firstWord.ToCharArray();

            if (firstWordInChar[0] == secondWordInChar[secondWordInChar.Length - 1])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public static void Task5()
        {
            // Дан текст. Определить, сколько в нем предложений. ​

            string text = "ghfsdghsfsjdhf. dsukfhhjsfgjsdhgf . sdhjgfsdhgfjh. sdfhjsdgfghjf.";
            char[] charText = text.ToCharArray();
            int j = 0;

            for (int i = 0; i < charText.Length; i++)
            {
                if (charText[i] == '.')
                {
                    if (charText[i + 1] != '.')
                    {
                        j++;
                    }
                }
            }
            Console.WriteLine(j);
        }

        public static void Task6()
        {
            // Дано предложение, в котором имеются одна буква с и одна буква Т. 
            // Определить, какая из них встречается раньше (при просмотре слова слева направо)​

            string sententh = "faigh";
            char[] sententhChar = sententh.ToCharArray();
            int charC = 0;
            int charT = 0;

            for (int i = 0; i < sententhChar.Length; i++)
            {
                if (sententhChar[i] == 'c' || sententhChar[i] == 'T')
                {
                    charC = i;
                }
                else if (sententhChar[i] == 't' || sententhChar[i] == 'T')
                {
                    charT = i;
                }
            }

            if (charC > charT)
            {
                Console.WriteLine("T");
            }
            else
            {
                Console.WriteLine("C");
            }
        }

        public static void Task7()
        {
            // Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой а. ​

            string sententh = "asdcfvghbjsdrfthjgshadbfghsduygyhjgbhdfujgyiulsdhgyuhfdjltgdsfghfsyufyugfdshjgj";
            char[] charSen = sententh.ToCharArray();

            for (int i = 2; i < charSen.Length; i += 3)
            {
                charSen[i] = 'a';
            }

            foreach (var item in charSen)
            {
                Console.Write(item);
            }
        }

        public static void Task8()
        {
            // Дано слово. Поменять местами его вторую и пятую буквы. ​

            string word = "phone";
            char[] charWord = word.ToCharArray();
            Console.WriteLine();

            if (word.Length >= 5)
            {
                char temp = charWord[1];
                charWord[1] = charWord[4];
                charWord[4] = temp;
            }

            foreach (var item in charWord)
            {
                Console.Write(item);
            }
        }

        public static void Task9()
        {
            // Дан текст. Найти сумму всех имеющихся в нем чисел.​

            string text = "sdfhjsdgfhsdg345 dhgfhsdgfj 655";
            
            Console.WriteLine("Text: " + text);
            char[] charText = text.ToCharArray();
            int sum = 0;


            for (int i = 0; i < charText.Length; i++)
            {
                if (Char.IsDigit(charText[i]))
                {
                    sum += int.Parse(text[i].ToString());
                }
            }
            Console.WriteLine($"Sum is{sum}");
        }

        public static void TaskWithStar()
        {
            {
                //*Дано натуральное число n(n  1000).Напечатать это число русскими словами(тринадцать,
                //сто пять, двести сорок один, тысяча и т.д.).  
                Console.WriteLine("TASK 10");

                string[] numsFrom1To19 = "ноль один два три четыре пять шесть семь восемь девять десять одиннадцать двенадцать тринадцать четырнадцать пятнадцать шестнадцать семнадцать восемнадцать девятнадцать".Split();

                string[] nums_20_90 = "ноль десять двадцать тридцать сорок пятьдесят шестьдесят семьдесят восемьдесят девяносто".Split();

                string[] nums_100_900 = "ноль сто двести триста четыреста пятьсот шестьсот семьсот восемьсот девятьсот".Split();

                Console.WriteLine("введите число от 0 до 1000");
                int number = int.Parse(Console.ReadLine());
                if (number < 20)
                {
                    Console.WriteLine(numsFrom1To19[number]);
                    if (number < 100 & number >= 20)
                    {
                        int _10 = number / 10;
                        int _1 = number % 10;
                        if (_1 != 0)
                            Console.WriteLine(nums_20_90[_10] + " " + numsFrom1To19[_1]);
                        else if (_1 == 0 & _10 != 0)
                            Console.WriteLine(nums_20_90[_10]);
                    }
                    if (number < 1000 & number >= 100)
                    {
                        int _100 = number / 100;
                        int _10_20 = number % 100;
                        int _10 = number % 100 / 10;
                        int _1 = number % 100 % 10;
                        if (_10_20 >= 10 & _10_20 < 20)
                            Console.WriteLine(nums_100_900[_100] + " " + numsFrom1To19[_10_20]);
                        else if (_10_20 == 0)
                            Console.WriteLine(nums_100_900[_100]);
                        else if (_1 == 0 & _10 != 0)
                            Console.WriteLine(nums_100_900[_100] + " " + nums_20_90[_10]);
                        else if (_10 == 0 & _1 != 0)
                            Console.WriteLine(nums_100_900[_100] + " " + numsFrom1To19[_1 + 10]);
                        else if (_1 != 0 & _10 != 0)
                            Console.WriteLine(nums_100_900[_100] + " " + nums_20_90[_10] + " " + numsFrom1To19[_1 + 10]);
                    }

                }
            }

        }
    }
}
