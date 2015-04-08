using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMyExcample
{
    class LineType2 : Line
    {
        public string Draw(string color)
        {
            return string.Format("Line2 color: {0}", color);
        }
    }
}
