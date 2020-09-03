using System;
using System.Collections.Generic;
using STARST.Mo.Core.Configuration.Core;

namespace STARST.Mo.Core.Configuration.Repository
{
    /// <summary>
    /// Represents a repository for getting configuration data
    /// </summary>
    public class ConfigRepository : IConfigRepository
    {
        public IEnumerable<KeyValuePair<string, string>> GetConfigItems()
        {
            throw new NotImplementedException();
        }
    }
}
