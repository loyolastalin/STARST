using STARST.Mo.Core.Logging.Core;

namespace STARST.Mo.Core.Logging
{
    /// <summary>
    /// Represents to write an entry of log into underlying log writer.
    /// </summary>
    public class Logger : ILogger
    {
        private static ILogger _instance = new Logger();

        public static ILogger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void LogInfo(string message)
        {
            ILogWriter writer = LogWriterfactory.GetLogWriter(LoggerType.EnterpriseLogWriter);
            writer.Log(message);
        }

        public void LogError(string message)
        {
            ILogWriter writer = LogWriterfactory.GetLogWriter(LoggerType.EnterpriseLogWriter);
            writer.Log(message);
        }

        public void LogWarning(string message)
        {
            ILogWriter writer = LogWriterfactory.GetLogWriter(LoggerType.EnterpriseLogWriter);
            writer.Log(message);
        }
    }
}
