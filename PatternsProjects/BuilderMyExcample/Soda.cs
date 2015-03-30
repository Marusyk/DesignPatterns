using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderMyExcample
{
    public class Soda
    {
        public string SodaName { get; set; }
        public string BottleName { get; set; }

        public string SodaProduct()
        {
            return string.Format("{0} in {1}", SodaName, BottleName);
        }
    }
}
