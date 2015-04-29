using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoMyExcample
{
    class Man
    {
        public string Clothes { get; set; }

        public void Dress(Backpack backpack)
        {
            Clothes = backpack.GetState();
        }

        public Backpack Undress()
        {
            return new Backpack(Clothes);
        }
    }
}
