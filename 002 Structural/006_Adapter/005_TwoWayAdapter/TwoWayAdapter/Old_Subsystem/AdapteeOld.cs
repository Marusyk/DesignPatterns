using System;

namespace TwoWayAdapter
{
    class AdapteeOld : ITargetOld
    {
        public void MethodOld()
        {
            Console.WriteLine("AdapteeOld.MethodOld");
        }
    }
}
