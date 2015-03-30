using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FireBirdProvider : IProvider
    {
        public AbstractConnection Connect()
        {
            return new FireBirdConnection();
        }

        public AbstractSqlExecution Execute()
        {
            return new FireBirdExecution();
        }
    }
}
