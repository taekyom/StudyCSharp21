using System;

namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class consoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormatableLogger : ILogger //interface 상속
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormatableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트");
            consoleLogger logger = new consoleLogger();
            logger.WriteLog("로그 메시지");

            IFormatableLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12); //IFormatableLogger.writelog(format, args);
        }
    }
}
