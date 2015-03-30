using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        private Builder Builder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
