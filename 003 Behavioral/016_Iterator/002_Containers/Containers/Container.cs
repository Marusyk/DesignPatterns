using System.Collections.Generic;
using System.ComponentModel;

namespace Containers
{
    class Container : IContainer
    {
        List<IComponent> list = new List<IComponent>();

        public ComponentCollection Components
        {
            get { return new ComponentCollection(list.ToArray()); }
        }

        // Реализация интерфейса IContainer.

        public virtual void Add(IComponent component)
        {
            list.Add(component);
        }

        public virtual void Add(IComponent component, string name)
        {
            component.Site = new Site
            {
                Component = component,
                Container = this,
                Name = name
            };

            list.Add(component);
        }

        public virtual void Remove(IComponent component)
        {
            list.Remove(component);
        }

        // Реализация интерфейса IDisposable.

        public virtual void Dispose()
        {           
            list.ForEach(component => component.Dispose());
            list.Clear();
        }
    }
}
