using System;
using System.Collections;

namespace Visitor
{
    class ObjectStructure
    {
        // Подчеркиваетсяя гетерогенность.
        ArrayList elements = new ArrayList();

        public void Add(Element element)
        {
            elements.Add(element);
        }

        public void Remove(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
                element.Accept(visitor);
        }
    }
}
