using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityMyExcample
{
    class EnglishGermanTranslator : Translator
    {
        public override void Request(string request)
        {
            if (request == "English-German")
                Console.WriteLine("Result from English-German translator");
            else if (Successor != null)
                Successor.Request(request);
        }
    }
}
