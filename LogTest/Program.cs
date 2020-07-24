using NLog;
using System;

namespace LogTest
{
    class Program
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                // log here
                logger.Trace("Trace");
                logger.Debug("Debug");
                logger.Info("Info");
                logger.Warn("Warn");
                logger.Error("Error");
                logger.Fatal("Fatal");

                int div = 0;
                div /= div;     //故意讓系統出現例外

            }
            catch (Exception ex)
            {
                // log with exception here
                logger.Trace(ex, "Trace");
                logger.Debug(ex, "Debug");
                logger.Info(ex, "Info");
                logger.Warn(ex, "Warn");
                logger.Error(ex, "Error");
                logger.Fatal(ex, "Fatal");

            }
        }
    }
}
