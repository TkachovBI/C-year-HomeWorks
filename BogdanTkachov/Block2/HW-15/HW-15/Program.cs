using System;
using System.Collections.Generic;

namespace HW_15
{   /* Построить три класса (базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой (один из потомков) и фиксированной оплатой (второй потомок).

    а) Описать в базовом классе метод для расчета среднемесячной заработной платы. Для «повременщиков» формула для расчета такова:
    «среднемесячная заработная плата = 20.8 * 8 * почасовую ставку»,для работников с фиксированной оплатой «среднемесячная заработная плата 
    = фиксированной месячной оплате».

    б) Создать на базе класса массив сотрудников и заполнить его.
    
    в) Реализовать метод для возможности сортировки массива используя Array.Sort().
    
    г) Реализовать возможность вывода данных с использованием foreach*/


    // a
    public class Base
    {
        public Base(string name, double salary)
        {
            Name = name;
            Salary = GetSalary(salary);
        }

        public double Salary { get; set; }
        public string Name { get; set; }

        public virtual double GetSalary(double salary)
        {
            return salary;
        }

        public void GetData()
        {
            Console.WriteLine($"{Name} is get {Salary}$ in month");
        }
    }


    public class DerivedClassFirst : Base
    {
        public override double GetSalary(double salary)
        {
            return 20.8 * 8 * salary;
        }

        public DerivedClassFirst(string name, double salary)
            : base(name, salary)
        {

        }
    }

    public class DerivedClassSecond : Base
    {
        public DerivedClassSecond(string name, double salary) 
            : base(name, salary)
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /* б) Создать на базе класса массив сотрудников и заполнить его.
    
    в) Реализовать метод для возможности сортировки массива используя Array.Sort().
    
    г) Реализовать возможность вывода данных с использованием foreach*/

            // c
            Base[] array = new Base[]
            {
                new DerivedClassFirst("Vasya", 20.0),

                new DerivedClassFirst("Petya", 40.0),

                new DerivedClassSecond("Fedya", 600.0),
            };

            foreach (var item in array)
            {
                item.GetData();
            }
            Console.WriteLine();

            double[] salaryArray = new double[array.Length];
            for (int i = 0; i < salaryArray.Length; i++)
            {
                salaryArray[i] = array[i].Salary;
            }
            Array.Sort(salaryArray);
            for (int i = 0; i < salaryArray.Length; i++)
            {
                for (int j = 0; j < salaryArray.Length; j++)
                {
                    if (salaryArray[i] == array[j].Salary)
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                item.GetData();
            }

            // d


        }
    }
}
