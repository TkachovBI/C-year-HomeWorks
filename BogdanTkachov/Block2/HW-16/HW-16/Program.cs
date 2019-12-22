namespace HW_16
{
    //4. Изучить Singelton.Создать класс, где необходимо подключить базу данных в проект и класс, 
    // который будет отвечать за соединение с ней.Один раз создается соединение и нет нужны создавать его снова и снова.
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseConnection dataBaseConnection = DataBaseConnection.Connected();            

            DataBaseConnection dataBaseConnectio1 = DataBaseConnection.Connected();

        }
    }
}
