using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Configuration
{
    /// <summary>
    ///  This class is derived from System.Exception class.
    ///  Represents an errors that is occurred during application execution.
    /// </summary>
    [Serializable]
    public class ConfigurationException : System.Exception
    {
        public ConfigurationException()
        {
        }

        public ConfigurationException(string message)
            : base(message)
        {
        }

        public ConfigurationException(string message, Exception exception)
            : base(message, exception)
        {
        }

        protected ConfigurationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
