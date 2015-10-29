using System;

namespace Memento
{
    class Man
    {
        public string Ñlothes { get; set; }

        public void Dress(Backpack backpack)
        {
            Ñlothes = backpack.Ñontents;
        }

        public Backpack Undress()
        {
            return new Backpack(Ñlothes);
        }
    }
}
