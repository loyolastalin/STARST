using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Logging.Core
{
    /// <summary>
    /// This interface defines set of methods for log an entry
    /// </summary>
    public interface ILogger
    {
        void LogInfo(string message);

        void LogError(string message);

        void LogWarning(string message);
    }
}
