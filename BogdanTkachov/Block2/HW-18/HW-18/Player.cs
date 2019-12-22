namespace HW_18
{
    class Player
    {
        private string name;
        private int number;

        public Player(string Name, int Number)
        {
            name = Name;
            number = Number;
        }

        public void GetInfo()
        {
            System.Console.WriteLine($"{name} play in Dnipro, and his number: {number}");
        }

    }
}
