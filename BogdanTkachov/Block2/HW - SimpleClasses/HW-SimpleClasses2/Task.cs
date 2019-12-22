using System;

namespace HW_SimpleClasses2
{

    class Children
    {
        /* Определить класс Children, который содержит такие поля (члены класса):
           закрытые – имя ребенка, фамилию и возраст , публичные – методы ввода данных и отображения их на экран. 
           Объявить два объекта класса, внести данные и показать их.*/

        private string name;
        private string firstName;
        private byte yearsOld;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        public byte YearsOld
        {
            get
            {
                return yearsOld;
            }

            set
            {
                yearsOld = value;
            }
        }

        public string Datas()
        {
            string all = $"{firstName} {name} is {yearsOld} years old";
            return all;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Children child1 = new Children();
            child1.Name = "Artem";
            child1.FirstName = "Artemenko";
            child1.YearsOld = 25;

            Console.WriteLine(child1.Datas());
        }
    }
}
