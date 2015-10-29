using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            // ��������.
            MicrosoftPress publisher = new MicrosoftPress();

            // ����������.
            Subscriber subscriber1 = new Subscriber(publisher, "Ivan");
            Subscriber subscriber2 = new Subscriber(publisher, "Anton");
            Subscriber subscriber3 = new Subscriber(publisher, "Alex");
            Subscriber subscriber4 = new Subscriber(publisher, "Serg");
            Subscriber subscriber5 = new Subscriber(publisher, "Igor");

            //-------------- 1-� ������ ������� ----------------

            // ���������� �����������.
            publisher.AddToClientList(subscriber1);
            publisher.AddToClientList(subscriber2);
            publisher.AddToClientList(subscriber3);
            publisher.AddToClientList(subscriber4);

            Magazine magazine = new Magazine();
            magazine.Title = "msdn";
            magazine.Content = "ASP.NET: ���������� ������� � ����������� � ������� �������� IIS  ... ";

            publisher.Magazine = magazine;
            publisher.SendMagazineToClient();

            Console.WriteLine(new string('-', 70));

            //-------------- 2-� ������ ������� ----------------

            // ���������� ������ ����������.
            publisher.AddToClientList(subscriber5);
            // �������� ������������� ����������.
            publisher.DeleteFromClientList(subscriber2);

            magazine = new Magazine();
            magazine.Title = "msdn";
            magazine.Content = "SQL Server: ��������� ������������ ����� OLAP � SQL Server � ������� C# ...";

            publisher.Magazine = magazine;
            publisher.SendMagazineToClient();

            Console.WriteLine(new string('-', 70));

            //-------------- N-� ������ ������� ----------------

            // ��������.
            Console.ReadKey();
        }
    }
}
