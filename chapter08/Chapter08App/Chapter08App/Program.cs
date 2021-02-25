using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08App
{
    class Program
    {
        interface ILogger //interface는 new할 수 없음(interface != class)
        {
            void WriteLog(string msg);

        }

        class ConsoleLogger : ILogger
        {
            public void WriteLog(string msg)
            {
                Console.WriteLine($"{DateTime.Now}log : {msg}");
            }
        }

        class ClimateLogger
        {
            private ILogger logger;
            public ClimateLogger(ILogger logger)
            {
                this.logger = logger;
            }

            public void start()
            {
                while (true)
                {
                    Console.Write("온도를 입력하세요 : ");
                    string temp = Console.ReadLine();
                    if (string.IsNullOrEmpty(temp)) break;

                    logger.WriteLog($"현재온도 : {temp}");
                }
            }
        }

        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("로그출력!"); //직접제어

            ClimateLogger cLogger = new ClimateLogger(new ConsoleLogger());
            cLogger.start(); //제어의 역흐름(IoC)
        }
    }
}
