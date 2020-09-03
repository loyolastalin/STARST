using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Configuration.Core
{
    /// <summary>
    /// Specification of the configuration reader.
    /// </summary>
    internal interface IConfigurationReader
    {
        string Get(string key);
    }
}
