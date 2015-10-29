using System;
using System.ComponentModel;

// В данном примере используются системные классы Container, Component и Site.

namespace Containers
{
    class Program
    {
        static void Main()
        {
            Container container = new Container();
            
            Component component1 = new Component();
            Component component2 = new Component();
            Component component3 = new Component();

            container.Add(component1, "First");
            container.Add(component2, "Second");
            container.Add(component3, "Third");

            ComponentCollection components = container.Components;

            foreach (Component component in components)
            {
                Console.WriteLine("Component : " + component.Site.Name);
            }

            component1.Disposed += (object sender, EventArgs e) => 
                Console.WriteLine("First Component Disposed");

            container.Dispose();

            // Delay.
            Console.ReadKey();
        }       
    }
}
