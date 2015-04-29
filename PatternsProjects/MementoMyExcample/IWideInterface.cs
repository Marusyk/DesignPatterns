using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoMyExcample
{
    interface IWideInterface : INarrowInterface
    {
        string GetState();
        void SetState(string s);
    }
}
