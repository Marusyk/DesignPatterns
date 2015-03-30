using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractSqlExecution
    {
        public abstract string Execute(string operationType);
    }
}
