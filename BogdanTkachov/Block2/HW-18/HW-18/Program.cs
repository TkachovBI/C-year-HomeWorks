using System;

namespace HW_18
{
    class Program
    {
        static void Main(string[] args)
        {

            Team Dnipro = new Team();

            Dnipro[0] = new Player("Sasha", 0);
            Dnipro[1] = new Player("Roma", 1);
            Dnipro[2] = new Player("Timur", 2);
            Dnipro[3] = new Player("Evgeni", 3);
            Dnipro[4] = new Player("Leonid", 4);
            Dnipro[5] = new Player("Gen", 5);
            Dnipro[6] = new Player("Valera", 6);
            Dnipro[7] = new Player("Bogdan", 7);
            Dnipro[8] = new Player("Artur", 8);
            Dnipro[9] = new Player("Misha", 9);
            Dnipro[10] = new Player("Igor", 10);
        start:;
            Console.Write("Write number of player: ");
            int count;
            bool nt = int.TryParse(Console.ReadLine(), out count);

            if (nt)
            {
                if (count <= 11)
                {
                    Dnipro[count].GetInfo();
                }
                else
                {
                    Console.WriteLine("in this team apsent this player");
                }
            }

            goto start;
        }
    }
}
