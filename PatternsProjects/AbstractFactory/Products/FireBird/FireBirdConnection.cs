using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FireBirdConnection : AbstractConnection
    {
        public override string Connect(string dababaseName)
        {
            string result = string.Format("ConnectionString:DataBase={0}; Provider=FireBird;", dababaseName);
            return result;
        }
    }
}
