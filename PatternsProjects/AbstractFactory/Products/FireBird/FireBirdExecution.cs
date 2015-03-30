using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FireBirdExecution : AbstractSqlExecution
    {
        public override string Execute(string operationType)
        {
            return string.Format("FireBirdExec: Type={0}; DateTime={1}", operationType, DateTime.Now.ToString());
        }
    }
}
