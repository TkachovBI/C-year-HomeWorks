using System;

namespace HW_19__Task_2
{/*2. Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода 
    void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
Написать программу, которая выполняет проигрывание и запись. */
    interface IPlayeble
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void PauseRecord();
        void StopRecord();
    }

    class Player : IPlayeble, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Playing is paused");
        }

        public void PauseRecord()
        {
            Console.WriteLine("Recording is paused");
        }

        public void Play()
        {
            Console.WriteLine("Playing is started");
        }

        public void Record()
        {
            Console.WriteLine("Recording is started");
        }

        public void Stop()
        {
            Console.WriteLine("Playing is stoped");
        }

        public void StopRecord()
        {
            Console.WriteLine("Recording is stoped");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Start record:  Ctrl+ R, S");
            Console.WriteLine("Pause record:  Ctrl+ R, P");
            Console.WriteLine("Stop record:  Ctrl+ R, E");
            Console.WriteLine("Start play:  Ctrl+ P");
            Console.WriteLine("Pause play:  Ctrl+ S, P");
            Console.WriteLine("Stop play:  Ctrl+ S, E");
            while (true)
            {
                Console.WriteLine("Start record");
                Console.WriteLine("Pause record");
                Console.WriteLine("Stop record");
                Console.WriteLine("Start play");
                Console.WriteLine("Pause play");
                Console.WriteLine("Stop play");

                Console.Write("Write operation which you need: ");
                string str = Console.ReadLine().ToLower();

                switch (str)
                {
                    case "start record":
                        player.Record();
                        break;

                    case "pause record":
                        player.PauseRecord();
                        break;

                    case "stop record":
                        player.StopRecord();
                        break;

                    case "start play":
                        player.Play();
                        break;

                    case "pause play":
                        player.Pause();
                        break;

                    case "stop play":
                        player.Stop();
                        break;

                    default:
                        Console.WriteLine("it is not corract operation");
                        break;
                }
            }
        }
    }
}
