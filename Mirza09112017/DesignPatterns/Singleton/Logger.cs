using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Singleton
{
    public class LoggerWithOutGetter
    {
        // making it static make its accessable to the static accessor and also makes it singleton
        // private static _logger object the singleton instance
        private static LoggerWithOutGetter _logger;

        // Make the constructor private so it can only instantiated once
        // and it instance can be retunred by get instance method
        private LoggerWithOutGetter()
        {

        }



        public static LoggerWithOutGetter GetLogger()
        {
            if (LoggerWithOutGetter._logger != null)
            {
                LoggerWithOutGetter._logger = new LoggerWithOutGetter();
            }

            return LoggerWithOutGetter._logger;
        }

    }

    public class Logger
    {
        // making it static make its accessable to the static accessor and also makes it singleton
        // private static _logger object the singleton instance
        private static Logger _logger;

        // Make the constructor private so it can only instantiated once
        // and it instance can be retunred by get instance method
        private Logger()
        {

        }

        // Simple Getter Setup
        public static Logger Instance
        {
            get{
                    if (Logger._logger != null)
                    {
                        Logger._logger = new Logger();
                    }

                    return Logger._logger;
                }
        }

    }
}
