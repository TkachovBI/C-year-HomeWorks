namespace HW_18
{
    class Team
    {
        Player[] players = new Player[11];

        public Player this[int index]
        {
            get
            {
                return players[index];
            }

            set
            {
                players[index] = value;
            }
        }

        
    }
}
