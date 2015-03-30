using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OracleExecution : AbstractSqlExecution
    {
        public override string Execute(string operationType)
        {
            return string.Format("Oracle SQL Exec = {0}", operationType);
        }
    }
}
