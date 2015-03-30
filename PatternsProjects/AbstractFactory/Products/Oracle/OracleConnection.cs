using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OracleConnection : AbstractConnection
    {
        public override string Connect(string dababaseName)
        {
            string dbProvider = "Oracle";
            string result = string.Format("ConnectionString:DataBase={0}; Provider={1}; Port=1251; User=oradba; Password=sa#001", dababaseName, dbProvider);
            return result;
        }
    }
}
