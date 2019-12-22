using System;

namespace TaskOrder
{

    class Order
    {
        /* Определить класс с именем Order содержащий следующие поля:
        - расчетный счет плательщика (формат уточнить в Интернете);
        - расчетный счет получателя;
        - перечисляемая сумма в грн, $, евро
        Методы:
        - упорядочить по убыванию перечисляемой суммы;
        - вывод информации о тех плательщиках, перечисляемая сумма которых не меньше суммы, введенной пользователем.
        - ввод данных в массив из n элементов типа Order в Main;*/



        public long firstCardNumber;
        public long secondCardNumber;

        private double moneyInEuro;
        private double moneyInDollar;
        private double moneyInUAN;

        public double sum1;
        public double sum2;
        public double sum3;
        public double sum;



        public Order(double sum1, double sum2, double sum3)
        {
            this.sum1 = sum1;
            this.sum2 = sum2;
            this.sum3 = sum3;
        }

        public Order(long firstCardNumber, long secondCardNumber, double moneyInUAN, double moneyInDollar, double moneyInEuro, double sum)
        {

            this.firstCardNumber = firstCardNumber;

            this.secondCardNumber = secondCardNumber;

            this.moneyInUAN = moneyInUAN;

            this.moneyInDollar = moneyInDollar;

            this.moneyInEuro = moneyInEuro;

            this.sum = sum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void TaskWithOrder()
        {
            Console.WriteLine("Number Of Card (sender) 1");
            double NumberOfCard1Send1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Poluchatel 1");
            double Poluch1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Write summ in UAN");
            double SumHrn1 = double.Parse(Console.ReadLine());
            double sum1 = SumHrn1;


            Console.WriteLine("Number Of Card (sender) 2");
            double NumberOfCard1Send2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Poluchatel 2");
            double Poluch2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Write summ in UAN");
            double SumHrn2 = double.Parse(Console.ReadLine());
            double sum2 = SumHrn2;


            Console.WriteLine("Number Of Card (sender) 3");
            double NumberOfCard1Send3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Poluchatel 3");
            double Poluch3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Write summ in UAN");
            double SumHrn3 = double.Parse(Console.ReadLine());
            double sum3 = SumHrn2;

            Order ord = new Order(sum1, sum2, sum3);


            Console.WriteLine("Введите сумму в грн: ");
            double sumPolz = double.Parse(Console.ReadLine());

            double[] CardSender = new double[3];
            CardSender[0] = NumberOfCard1Send1;
            CardSender[1] = NumberOfCard1Send2;
            CardSender[2] = NumberOfCard1Send3;

            double[] poluch = new double[3];
            poluch[0] = Poluch1;
            poluch[1] = Poluch2;
            poluch[2] = Poluch3;

            double[] HRN = new double[3];
            HRN[0] = SumHrn1;
            HRN[1] = SumHrn2;
            HRN[2] = SumHrn3;

            double[] Comparison = new double[3];
            Comparison[0] = sum1;
            Comparison[1] = sum2;
            Comparison[2] = sum3;
            Console.WriteLine("Информация о платильщиках, чья сумма больше " + sumPolz);

            for (int i = 0; i < Comparison.Length; i++)
            {
                if (Comparison[i] >= sumPolz)
                {
                    Console.WriteLine($"Карта отправителя: {CardSender[i]}, получателя: {poluch[i]}");
                }
            }

        }
    }

}
