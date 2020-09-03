using STARST.Mo.Core.Logging.Core;

namespace STARST.Mo.Core.Logging
{
    /// <summary>
    /// Creates an instance of log writer for specified writer type provided by the caller.
    /// </summary>
    internal class LogWriterfactory
    {
        private LogWriterfactory()
        {
        }

        public static ILogWriter GetLogWriter(LoggerType loggerType)
        {
            switch (loggerType)
            {
                case LoggerType.EnterpriseLogWriter:
                    return new EnterpriseLogWriter();
            }

            return null;
        }
    }
}
