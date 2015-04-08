using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMyExcample
{
    class LineType1 : Line
    {
        public string Draw(string color)
        {
            return string.Format("Line1 color: {0}", color);
        }
    }
}
