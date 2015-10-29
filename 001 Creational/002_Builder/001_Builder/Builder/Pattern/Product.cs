using System;
using System.Collections;

namespace Builder
{
    class Product
    {
        ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
