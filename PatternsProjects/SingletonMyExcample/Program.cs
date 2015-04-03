using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMyExcample
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerSingleton logger = LoggerSingleton.GetInstance();
            HardProcessor processor = new HardProcessor(1);
            logger.Log("Hard work started...");
            processor.ProcessTo(5);
            logger.Log("Hard work finished...");

            Console.ReadKey();
        }
    }

    class LoggerSingleton
    {
        private LoggerSingleton() { }
        private int _logCount = 0;
        private static LoggerSingleton _loggerSingletonInstance = null;
        public static LoggerSingleton GetInstance()
        {
            if (_loggerSingletonInstance == null)
                _loggerSingletonInstance = new LoggerSingleton();
            return _loggerSingletonInstance;
        }

        public void Log(string message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    } 

    class HardProcessor
    {
        private int _start;
        public HardProcessor(int start)
        {
            _start = start;
            LoggerSingleton.GetInstance().Log("Processor just created. ");
        }

        public int ProcessTo(int end)
        {
            int sum = 0;
            for (int i = _start; i <= end; ++i)
            {
                sum += i;
            }
            LoggerSingleton.GetInstance().Log("Processor just calculated some value: " + sum);
            return sum;
        }
    }
}
