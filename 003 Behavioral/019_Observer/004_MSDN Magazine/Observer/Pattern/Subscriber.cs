using System;

namespace Observer
{
    abstract class AbstractSubscriber
    {
        public abstract void Deliver();
    }

    class Subscriber : AbstractSubscriber
    {
        private string name;
        private Magazine magazine;
        private MicrosoftPress publisher;

        public Subscriber(MicrosoftPress publisher, string name)
        {
            this.publisher = publisher;
            this.name = name;
        }

        public override void Deliver()
        {
            magazine = publisher.Magazine;
            Console.WriteLine("Подписчик {0} получил журнал: {1} со статьей: \n {2}", 
                name, magazine.Title, magazine.Content);
        }
    }
}
