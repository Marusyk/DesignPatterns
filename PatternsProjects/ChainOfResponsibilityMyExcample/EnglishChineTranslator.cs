using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityMyExcample
{
    class EnglishChineTranslator : Translator
    {
        public override void Request(string request)
        {
            if (request == "English-China")
                Console.WriteLine("Result from English-China translator");
            else if (Successor != null)
                Successor.Request(request);
        }
    }
}
