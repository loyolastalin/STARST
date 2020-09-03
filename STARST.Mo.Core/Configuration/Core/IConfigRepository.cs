using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARST.Mo.Core.Configuration.Core
{
    /// <summary>
    /// This interface acts as a contract for ConfigurationRepository.
    /// </summary>
    internal interface IConfigRepository
    {
        IEnumerable<KeyValuePair<string, string>> GetConfigItems();
    }
}
