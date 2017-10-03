using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using StructureMap;
using StructureMap.Graph.Scanning;

namespace Mirza09112017.StructureMap
{
    public static class StructureMap
    {
        public static void Main(string[] args)
        {
            var container = Container.For<ApplicationRegistery>();
            container.GetInstance<Application>().Run();

            var log = container.GetInstance<ILog>();
            int i = 10;
        }
    }

    public class ApplicationRegistery : Registry
    {
        public ApplicationRegistery()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            // Explicit Registration is only required when convention
            // isn't followed
            For<ILog>().Use<ConsoleLogger>()
                .Ctor<ConsoleColor>("color").Is(ConsoleColor.Green);
                //.Setter<ConsoleColor>("color").Is(ConsoleColor.Cyan);
        }
    }

    public class Application
    {
        private ILog log;
        private InitA obj;

        public Application(ILog log, InitA classA)
        {
            this.log = log;
            this.obj = classA;
        }

        public void Run()
        {
            log.Info("Test");
            obj.MethodA();
            Console.ReadKey();
        }
    }

    public interface ILog
    {
        void Info(string message, ConsoleColor color = ConsoleColor.Blue);
        
    }

    public class ConsoleLogger : ILog
    {
        private ConsoleColor color;

        public ConsoleLogger(ConsoleColor color)
        {
            this.color = color;
        }
        public void Info(string message,ConsoleColor c)
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine(message);
        }
        
    }

    public class DBLogger : ILog
    {
        public void Info(string message , ConsoleColor color = ConsoleColor.Black)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
        }
    }

    public class InitA
    {
        private ILog log;
        public InitA(ILog log)
        {
            this.log = log;
        }

        public void MethodA()
        {
            log.Info("Call Method A",ConsoleColor.Red);
        }
    }

}
