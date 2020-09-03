using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Logging.Core
{
    /// <summary>
    /// Specification for the log writer.
    /// </summary>
    internal interface ILogWriter
    {
        void Log(string message);
    }
}
