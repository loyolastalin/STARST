using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Configuration.Core
{
    /// <summary>
    /// Specification of the configuration manager
    /// </summary>
    public interface IConfigurationManager
    {
        T GetValue<T>(string key);
    }
}
