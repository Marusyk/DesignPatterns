using System;
using System.ComponentModel;

namespace Containers
{
    class Site : ISite
    {
        // Реализация интерфейса ISite.

        public virtual IComponent Component { get;  set; }
        public virtual IContainer Container { get;  set; }
        public virtual bool DesignMode { get { return false; } }
        public virtual string Name { get; set; }

        // Реализация интерфейса IServiceProvider.

        public virtual object GetService(Type serviceType)
        {
            // В данном примере не используются сервисы.
            return null;
        }
    }
}
