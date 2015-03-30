using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        AbstractConnection connection;
        AbstractSqlExecution execution;

        private string DataBaseName { get; set; }
        private string OperationType { get; set; }

        public Client(IProvider factory, string dbName = "default", string operationType = "select")
        {
            DataBaseName = dbName;
            OperationType = operationType;

            connection = factory.Connect();
            execution = factory.Execute();
        }

        public void Run()
        {
            Console.WriteLine("Connection String = {0}", connection.Connect(DataBaseName));
            Console.WriteLine("SqlExecute = {0}", execution.Execute(OperationType));
        }
    }
}
