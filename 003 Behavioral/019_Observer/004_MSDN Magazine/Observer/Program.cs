using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            // Издатель.
            MicrosoftPress publisher = new MicrosoftPress();

            // Подписчики.
            Subscriber subscriber1 = new Subscriber(publisher, "Ivan");
            Subscriber subscriber2 = new Subscriber(publisher, "Anton");
            Subscriber subscriber3 = new Subscriber(publisher, "Alex");
            Subscriber subscriber4 = new Subscriber(publisher, "Serg");
            Subscriber subscriber5 = new Subscriber(publisher, "Igor");

            //-------------- 1-й выпуск журнала ----------------

            // Добавление подписчиков.
            publisher.AddToClientList(subscriber1);
            publisher.AddToClientList(subscriber2);
            publisher.AddToClientList(subscriber3);
            publisher.AddToClientList(subscriber4);

            Magazine magazine = new Magazine();
            magazine.Title = "msdn";
            magazine.Content = "ASP.NET: Устранение проблем в приложениях с помощью журналов IIS  ... ";

            publisher.Magazine = magazine;
            publisher.SendMagazineToClient();

            Console.WriteLine(new string('-', 70));

            //-------------- 2-й выпуск журнала ----------------

            // Добавление нового подписчика.
            publisher.AddToClientList(subscriber5);
            // Удаление существующего подписчика.
            publisher.DeleteFromClientList(subscriber2);

            magazine = new Magazine();
            magazine.Title = "msdn";
            magazine.Content = "SQL Server: Модульное тестирование кубов OLAP в SQL Server с помощью C# ...";

            publisher.Magazine = magazine;
            publisher.SendMagazineToClient();

            Console.WriteLine(new string('-', 70));

            //-------------- N-й выпуск журнала ----------------

            // Задержка.
            Console.ReadKey();
        }
    }
}
