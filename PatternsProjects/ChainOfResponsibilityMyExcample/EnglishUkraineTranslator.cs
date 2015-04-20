using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityMyExcample
{
    class EnglishUkraineTranslator : Translator
    {
        public override void Request(string request)
        {
            if (request == "English-Ukraine")
                Console.WriteLine("Result from English-Ukraine translator");
            else if (Successor != null)
                Successor.Request(request);
        }
    }
}
