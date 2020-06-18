using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    interface ILogger
    {
        void Log(string msg);
    }

    interface IConsoleLogger : ILogger
    {
        void ILogger.Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class ConsoleLogger : IConsoleLogger
    {
    }

    interface IDatabaseLogger : ILogger
    {
        string Database { get; set; }
        void ILogger.Log(string msg)
        {
            GetSpecString();
            Console.WriteLine($"{msg} inserted in {Database}");
        }

        string GetSpecString()
        {
            return "Spec";
        }
    }
    class DatabaseLogger : IDatabaseLogger
    {
        public string Database { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    //Several loggers
    static class LoggerFactory
    {
        public static ILogger GetLogger(LoggerType lt) => lt switch
        {
            LoggerType.Console => new ConsoleLogger(),
            LoggerType.Database => new DatabaseLogger(),
            _ => throw new Exception("Logger doesn't exist")
        };
    }

    enum LoggerType { Console, Database }
    public class DefaultInterfacesMembers
    {
        public static void GetLogger()
        {
            var lc = LoggerFactory.GetLogger(LoggerType.Console);
            lc.Log("Msg");

            var ld = LoggerFactory.GetLogger(LoggerType.Database);
            ld.Log("Msg");
        }
    }
}
