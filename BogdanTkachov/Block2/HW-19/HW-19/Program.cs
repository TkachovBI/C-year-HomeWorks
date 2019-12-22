using System;

namespace HW_19
{/* 1. Создайте класс AbstractHandler. 
В теле класса создать методы void Open(), void Create(), void Change(), void Save(). 
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия,
создания, редактирования, сохранения определенного формата документа. */

    abstract class AbstractHandler
    {
        public abstract void Open(string Name);
        public abstract void Create(string Name);
        public abstract void Change(string Name1, string Name2);
        public abstract void Save(string Name);
    }

    class XMLHandler : AbstractHandler
    {
        public override void Change(string Name1, string Name2)
        {
            Console.WriteLine($"We are changing {Name1}.xml and {Name2}.xml");
        }

        public override void Create(string Name)
        {
            Console.WriteLine($"We are created {Name}.xml");
        }

        public override void Open(string Name)
        {
            Console.WriteLine($"We are opened {Name}.xml");
        }

        public override void Save(string Name)
        {
            Console.WriteLine($"We are saving {Name}.xml");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Change(string Name1, string Name2)
        {
            Console.WriteLine($"We are changing {Name1}.txt and {Name2}.txt");
        }

        public override void Create(string Name)
        {
            Console.WriteLine($"We are created {Name}.txt");
        }

        public override void Open(string Name)
        {
            Console.WriteLine($"We are opened {Name}.txt");
        }

        public override void Save(string Name)
        {
            Console.WriteLine($"We are saving {Name}.txt");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Change(string Name1, string Name2)
        {
            Console.WriteLine($"We are changing {Name1}.doc and {Name2}.doc");
        }

        public override void Create(string Name)
        {
            Console.WriteLine($"We are created {Name}.doc");
        }

        public override void Open(string Name)
        {
            Console.WriteLine($"We are opened {Name}.doc");
        }

        public override void Save(string Name)
        {
            Console.WriteLine($"We are saving {Name}.doc");
        }
    }



    class Program
    {
        static void Main()
        {
            string name;
            Console.Write("Write name: ");
            name = Console.ReadLine();

            string format;
            Console.Write("Write please format of the file(whith out point or dot): ");
            format = Console.ReadLine();

            string operation;
            Console.Write("Write, which operetion you want to make(open, create, save, change): ");
            operation = Console.ReadLine().ToLower();


            switch (format)
            {
                case "xml":

                    AbstractHandler xml = new XMLHandler();

                    switch (operation)
                    {
                        case "open":
                            xml.Open(name);
                            break;

                        case "create":
                            xml.Create(name);
                            break;

                        case "save":
                            xml.Save(name);
                            break;

                        case "change":
                            Console.Write("Write name of second file: ");
                            string name2 = Console.ReadLine();
                            xml.Change(name, name2);
                            break;

                        default:
                            Console.WriteLine("It is not corract operation for our Program");
                            break;
                    }

                    break;

                case "txt":
                    AbstractHandler txt = new TXTHandler();

                    switch (operation)
                    {
                        case "open":
                            txt.Open(name);
                            break;

                        case "create":
                            txt.Create(name);
                            break;

                        case "save":
                            txt.Save(name);
                            break;

                        case "change":
                            Console.Write("Write name of second file: ");
                            string name2 = Console.ReadLine();
                            txt.Change(name, name2);
                            break;

                        default:
                            Console.WriteLine("It is not corract operation for our Program");
                            break;
                    }
                    break;

                case "doc":
                    AbstractHandler doc = new DOCHandler();

                    switch (operation)
                    {
                        case "open":
                            doc.Open(name);
                            break;

                        case "create":
                            doc.Create(name);
                            break;

                        case "save":
                            doc.Save(name);
                            break;

                        case "change":
                            Console.Write("Write name of second file: ");
                            string name2 = Console.ReadLine();
                            doc.Change(name, name2);
                            break;

                        default:
                            Console.WriteLine("It is not corract operation for our Program");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("It is not corract format for our Program");
                    break;
            }
        }
    }
}
