using System;

namespace ConsoleApp1
{
    class worker
    {
        /* 2. Определить класс с именем Worker, содержащий следующие поля:
    - фамилия и инициалы работника;
    - название занимаемой должности;
    - год поступления на работу.
    Методы:
    - ввод данных в массив из n элементов в типа Worker;
    - упорядочить по алфавиту фамилии работников;
    - вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.*/

        public string FirstName;
        public string Inizials;
        public int WhenStartWork;

        public worker(string FirstName, string Inizials, int WhenStartWork)
        {
            this.FirstName = FirstName;
            this.Inizials = Inizials;
            this.WhenStartWork = WhenStartWork;
        }
    }
    class Program
    {
        static void Main()
        {
            /* - ввод данных в массив из n элементов в типа Worker;
            - упорядочить по алфавиту фамилии работников;
            - вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.*/

            worker worker1 = new worker("Tkachov", "B.I.", 2015);
            worker worker2 = new worker("Sidorenko", "m.I.", 2000);
            worker worker3 = new worker("Anufrev", "a.I.", 2001);

            string[] FirstNames = { worker1.FirstName, worker2.FirstName, worker3.FirstName };

            string[] FirstNamesSort = { worker1.FirstName, worker2.FirstName, worker3.FirstName };
            Array.Sort(FirstNamesSort);
            foreach (var item in FirstNamesSort)
            {
                Console.WriteLine(item);
            }


            int profi;
            Console.Write("Hello, please, write work experience of worker");
            int.TryParse(Console.ReadLine(), out profi);

            int[] HowLongWork = { 2019 - worker1.WhenStartWork, 2019 - worker2.WhenStartWork, 2019 - worker3.WhenStartWork };

            for (int i = 0; i < HowLongWork.Length; i++)
            {

                if (HowLongWork[i] >= profi)
                {
                    Console.WriteLine(FirstNames[i]);
                }

            }

        }
    }
}
