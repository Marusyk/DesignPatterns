using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    // Широкий интерфейс
    interface IWideInterface : INarrowInterface
    {
        string State { get;  set; }
    }
}
