using System;

namespace HW_16
{
    class DataBaseConnection  // singleton
    {
        public bool isConnect = false;
        private static DataBaseConnection instance;

        protected DataBaseConnection()
        {

        }

        public static DataBaseConnection Connected()
        {
            
            if (instance == null)
            {
                Console.WriteLine("We are connecting now");
                instance = new DataBaseConnection();
            }
            else
            {
                Console.WriteLine("We can\'t connect, because we are connected early");
            }

            return instance;
        }
    }
}
