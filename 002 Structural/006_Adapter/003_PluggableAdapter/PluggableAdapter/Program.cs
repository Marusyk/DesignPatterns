using System;
using System.Collections.Generic;

// Сменный адаптер.

namespace MyNamespace
{
    // ---------- Существующие в системе типы ----------

    interface ITarget
    {
        void Request();
    }

    class Target : ITarget
    {
        void ITarget.Request()
        {
            Console.WriteLine("Target.Request");
        }
    }

    // ---------- Классы требующие адаптации ----------

    class AdapteeA
    {
        public void SpecificRequestA()
        {
            Console.WriteLine("AdapteeA.SpecificRequestA");
        }
    }

    class AdapteeB
    {
        public void SpecificRequestB()
        {
            Console.WriteLine("AdapteeB.SpecificRequestB");
        }
    }

    // ---------- Механизмы адаптации ----------

    enum Adaptee
    {
        A, B
    }

    // Сменный адаптер может адаптировать любое количество Adaptee.
    class PluggableAdapter : ITarget
    {
        Action request;

        public PluggableAdapter(Adaptee adaptee)
        {
            switch (adaptee)
            {
                case Adaptee.A:
                    {
                        request = new AdapteeA().SpecificRequestA;
                    }
                    break;
                case Adaptee.B:
                    {
                        request = new AdapteeB().SpecificRequestB;
                    }
                    break;
            }
        }

        void ITarget.Request()
        {
            request.Invoke();
        }
    }

    class Client
    {
        static void Main()
        {
            List<ITarget> targets = new List<ITarget>();

            targets.Add(new Target());

            targets.Add(new PluggableAdapter(Adaptee.A));
            // или/и ...
            targets.Add(new PluggableAdapter(Adaptee.B));
            
            foreach (ITarget target in targets)
                target.Request();
            
            // Delay.
            Console.ReadKey();
        }
    }
}


