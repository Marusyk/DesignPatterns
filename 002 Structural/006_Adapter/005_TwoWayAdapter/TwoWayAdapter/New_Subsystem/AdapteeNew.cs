using System;

namespace TwoWayAdapter
{
    class AdapteeNew : ITargetNew
    {
        public void MethodNew()
        {
            Console.WriteLine("AdapteeNew.MethodNew");
        }
    }
}
