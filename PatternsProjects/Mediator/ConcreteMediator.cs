using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public override void Send(string msg, Colleague сolleague)
        {
            if (Colleague1 == сolleague)
                Colleague2.Notify(msg);
            else
                Colleague1.Notify(msg);
        }
    }
}
