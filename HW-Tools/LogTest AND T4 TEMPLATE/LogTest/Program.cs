using log4net;
using log4net.Config;

public class LogTest
{
    private static readonly ILog logger =
           LogManager.GetLogger(typeof(LogTest));

 
    

    static void Main(string[] args)
    {
        BasicConfigurator.Configure();
        logger.Debug("LOG4NET Example:");
        logger.Info("This is an Info log.");
        logger.Warn("This is a warning.");
        logger.Error("This is an error.");
        logger.Fatal("This is a fatal error.");
    }
}