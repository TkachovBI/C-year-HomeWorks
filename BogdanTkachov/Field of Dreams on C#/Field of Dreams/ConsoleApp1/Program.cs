using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
        reload:
            Console.WriteLine("Hello, choose language(Russian, English, Ukrainian): ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "English":
                    Console.WriteLine("Hello let\'s play \"Field of Dreams in IT\"");
                    EngGame();
                    break;


                case "Russian":
                    Console.WriteLine("Приветик, давайте поиграем в \"Поле чудес в IT и компьютерной сфере\"");
                    RusGame();
                    break;

                case "Ukrainian":
                    Console.WriteLine("Привіт, давай пограємо в \"Поле чудес в IT сфері\"");
                    UkrGame();
                    break;

                default:
                    Console.WriteLine("I don\'t now this language) Programm will reload");
                    goto reload;


            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public static void RusGame()
        {
            string[] arrayRu = new string[10];

            int i = 0;


            arrayRu[i++] = "компилятор";
            arrayRu[i++] = "работа";
            arrayRu[i++] = "компьютер";
            arrayRu[i++] = "проєкт";
            arrayRu[i++] = "консоль";
            arrayRu[i++] = "митинг";
            arrayRu[i++] = "команда";
            arrayRu[i++] = "ноутбук";
            arrayRu[i++] = "клавиатура";
            arrayRu[i] = "наушники";


            int index = new Random().Next(0, 10);

            char[] word = arrayRu[index].ToCharArray();

            bool[] guessed = new bool[word.Length];

            for (int c = 0; c < guessed.Length; c++)
            {
                guessed[c] = false;
            }

            char[] lettersError = { '_', '_', '_', '_', '_' };

            Console.WriteLine("Угадай моё секретное слово, удачи. В нём " + word.Length + " букв, и вы можете угадывать только одну букву за раз)");
            Console.WriteLine("Вы можете сделать 5 ошибок");
            int error = 0;
            int guess = 0;
            int WasOk = 0;
            int a = 0;
            char write;

            while (error < 5)
            {
                Console.Write("Ты ещё можешь сделать ");

                switch (5 - error)
                {
                    case 5:
                        Console.WriteLine(5 - error + " Ошибок");
                        break;
                    case 4:
                    case 3:
                    case 2:
                        Console.WriteLine(5 - error + " Ошибки");
                        break;

                    case 1:
                        Console.WriteLine(5 - error + " Ошибку");
                        break;

                }
                Console.Write("Напиши букву, которая по твоему мнению есть в моём слове:");


                bool isChar = char.TryParse(Console.ReadLine(), out write);

                if (isChar)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == write)
                        {
                            guess++;
                            guessed[j] = true;

                        }
                    }

                }

                Console.Write("Ваше слово: ");

                for (int z = 0; z < guessed.Length; z++)
                {
                    if (guessed[z] == true)
                    {
                        a++;
                    }
                }
                if (a == WasOk)
                {
                    lettersError[error] = write;
                    error++;
                }
                WasOk = a;
                a = 0;
                for (int b = 0; b < guessed.Length; b++)
                {
                    if (guessed[b] == true)
                    {
                        Console.Write(word[b]);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
                Console.WriteLine();
                Console.Write("Ваши ошибки: ");

                Console.WriteLine();
                for (int v = 0; v < 5; v++)
                {
                    Console.Write(lettersError[v] + "\t");
                }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

                if (WasOk == word.Length)
                {
                    goto WinRu;
                }
            }
        WinRu:
            if (error < 5)
            {
                WinRu();
            }
            else
            {
                Console.WriteLine("Ты проиграл мою игру, теперь плати мне)");
            }




        }
        public static void WinRu()
        {

            Console.WriteLine("Ты выиграл, молодец, ты спец в пк или IT)");
        }

        public static void EngGame()
        {
            string[] arrayRu = new string[10];

            int i = 0;


            arrayRu[i++] = "mouse";
            arrayRu[i++] = "work";
            arrayRu[i++] = "laptop";
            arrayRu[i++] = "enternet";
            arrayRu[i++] = "monitor";
            arrayRu[i++] = "project";
            arrayRu[i++] = "team";
            arrayRu[i++] = "adapter";
            arrayRu[i++] = "keyboard";
            arrayRu[i] = "headset";


            int index = new Random().Next(0, 10);

            char[] word = arrayRu[index].ToCharArray();

            bool[] guessed = new bool[word.Length];

            for (int c = 0; c < guessed.Length; c++)
            {
                guessed[c] = false;
            }

            char[] lettersError = { '_', '_', '_', '_', '_' };

            Console.WriteLine("Guess my secret word in them are " + word.Length + " letters, add you can guess one letter in one attempt)");
            Console.WriteLine("You can make 5 errors");
            int error = 0;
            int guess = 0;
            int WasOk = 0;
            int a = 0;
            char write;

            while (error < 5)
            {
                Console.Write("You can still do ");

                switch (5 - error)
                {
                    case 5:
                        Console.WriteLine(5 - error + " Errors");
                        break;
                    case 4:
                    case 3:
                    case 2:
                        Console.WriteLine(5 - error + " Errors");
                        break;

                    case 1:
                        Console.WriteLine(5 - error + " Errors");
                        break;

                }
                Console.Write("Write the letter, that you think is in my word: ");


                bool isChar = char.TryParse(Console.ReadLine(), out write);

                if (isChar)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == write)
                        {
                            guess++;
                            guessed[j] = true;

                        }
                    }

                }

                Console.Write("Your word is: ");

                for (int z = 0; z < guessed.Length; z++)
                {
                    if (guessed[z] == true)
                    {
                        a++;
                    }
                }
                if (a == WasOk)
                {
                    lettersError[error] = write;
                    error++;
                }
                WasOk = a;
                a = 0;
                for (int b = 0; b < guessed.Length; b++)
                {
                    if (guessed[b] == true)
                    {
                        Console.Write(word[b]);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
                Console.WriteLine();
                Console.Write("Your errors: ");

                Console.WriteLine();
                for (int v = 0; v < 5; v++)
                {
                    Console.Write(lettersError[v] + "\t");
                }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();

                if (WasOk == word.Length)
                {
                    goto WinEn;
                }
            }
        WinEn:
            if (error < 5)
            {
                WinEng();
            }
            else
            {
                Console.WriteLine("You lose, sell me some money)");
            }




        }


        public static void WinEng()
        {
            Console.WriteLine("You are win, you are profi in IT or PC sphere");
        }


        public static void UkrGame()
        {
            string[] arrayRu = new string[10];

            int i = 0;


            arrayRu[i++] = "компілятор";
            arrayRu[i++] = "робота";
            arrayRu[i++] = "комп'ютер";
            arrayRu[i++] = "проект";
            arrayRu[i++] = "консоль";
            arrayRu[i++] = "мітинг";
            arrayRu[i++] = "команда";
            arrayRu[i++] = "ноутбук";
            arrayRu[i++] = "клавіатура";
            arrayRu[i] = "навушники";


            int index = new Random().Next(0, 10);

            char[] word = arrayRu[index].ToCharArray();

            bool[] guessed = new bool[word.Length];

            for (int c = 0; c < guessed.Length; c++)
            {
                guessed[c] = false;
            }

            char[] lettersError = { '_', '_', '_', '_', '_' };

            Console.WriteLine("Вгадай моє секретне слово, в ньому " + word.Length + " букв, і ви можете вгадувати тільки одну букву за раз)");
            Console.WriteLine("Ти можеш зробити 5 помилок");
            int error = 0;
            int guess = 0;
            int WasOk = 0;
            int a = 0;
            char write;

            while (error < 5)
            {
                Console.Write("Ти ще можеш зробити: ");

                switch (5 - error)
                {
                    case 5:
                        Console.WriteLine(5 - error + " помилок");
                        break;
                    case 4:
                    case 3:
                    case 2:
                        Console.WriteLine(5 - error + " помилки");
                        break;

                    case 1:
                        Console.WriteLine(5 - error + " помилку");
                        break;

                }
                Console.Write("Напиши букву, яка на твою думку є в моєму слові:");


                bool isChar = char.TryParse(Console.ReadLine(), out write);

                if (isChar)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == write)
                        {
                            guess++;
                            guessed[j] = true;

                        }
                    }

                }

                Console.Write("Ваше слово: ");

                for (int z = 0; z < guessed.Length; z++)
                {
                    if (guessed[z] == true)
                    {
                        a++;
                    }
                }
                if (a == WasOk)
                {
                    lettersError[error] = write;
                    error++;
                }
                WasOk = a;
                a = 0;
                for (int b = 0; b < guessed.Length; b++)
                {
                    if (guessed[b] == true)
                    {
                        Console.Write(word[b]);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
                Console.WriteLine();

                Console.Write("Ваші помилки: ");

                Console.WriteLine();

                for (int v = 0; v < 5; v++)
                {
                    Console.Write(lettersError[v] + "\t");
                }

                System.Threading.Thread.Sleep(2000);
                Console.Clear();

                if (WasOk == word.Length)
                {
                    goto WinUkr;
                }
            }
        WinUkr:
            if (error < 5)
            {
                WinUkr();
            }
            else
            {
                Console.WriteLine("Ти програв мою гру, тепер плати мені)");
            }

        }
        public static void WinUkr()
        {

            Console.WriteLine("Ти виграв, молодець, ти спец в пк або IT)");
        }

    }
}

