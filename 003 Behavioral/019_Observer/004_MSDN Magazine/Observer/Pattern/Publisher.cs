using System;
using System.Collections;

namespace Observer
{
    abstract class AbstractPublisher
    {
        private ArrayList subscriberList = new ArrayList();

        public void AddToClientList(AbstractSubscriber abstractSubscriber)
        {
            subscriberList.Add(abstractSubscriber);
        }

        public void DeleteFromClientList(AbstractSubscriber abstractSubscriber)
        {
            subscriberList.Remove(abstractSubscriber);
        }

        public void SendMagazineToClient()
        {
            foreach (AbstractSubscriber subscriber in subscriberList)
                subscriber.Deliver();
        }
    }

    class MicrosoftPress : AbstractPublisher
    {
        public Magazine Magazine { get; set; }
    }
}
