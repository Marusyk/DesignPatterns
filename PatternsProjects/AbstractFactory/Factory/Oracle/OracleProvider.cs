using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OracleProvider : IProvider
    {
        public AbstractConnection Connect()
        {
            return new OracleConnection();
        }

        public AbstractSqlExecution Execute()
        {
            return new OracleExecution();
        }
    }
}
