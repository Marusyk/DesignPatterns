using System;

namespace Memento
{
    class Man
    {
        public string �lothes { get; set; }

        public void Dress(Backpack backpack)
        {
            �lothes = backpack.�ontents;
        }

        public Backpack Undress()
        {
            return new Backpack(�lothes);
        }
    }
}
