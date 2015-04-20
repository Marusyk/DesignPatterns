using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator EnDe = new EnglishGermanTranslator();
            Translator EnCh = new EnglishChineTranslator();
            Translator EnUa = new EnglishUkraineTranslator();

            EnDe.Successor = EnCh;
            EnCh.Successor = EnUa;
            Console.WriteLine("First request: English-China ......");
            EnDe.Request("English-China");
            Console.WriteLine("Second request: English-Ukraine ......");
            EnDe.Request("English-Ukraine");
            Console.WriteLine("Third request: English-Ressian ......");
            EnDe.Request("English-Ressian");

            Console.ReadKey();
        }
    }
}
