using System;

namespace Proxy
{
    class Surrogate : IHuman
    {
        IHuman @operator;

        public Surrogate(IHuman @operator)
        {
            this.@operator = @operator;
        }

        public void Request()
        {
            this.@operator.Request();
        }
    }
}
