using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMyExcample
{
    abstract class Shape
    {
        protected string pen = null;
        
        public Line implementor = null;

        public virtual void Draw(string color)
        {
            this.pen = implementor.Draw(color);
            Console.WriteLine(pen);
        }
    }
}
