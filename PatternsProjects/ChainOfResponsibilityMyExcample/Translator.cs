using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityMyExcample
{
    abstract class Translator
    {
        public Translator Successor { get; set; }
        public abstract void Request(string request); 
    }
}
