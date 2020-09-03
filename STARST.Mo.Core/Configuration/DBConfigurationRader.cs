using System;
using STARST.Mo.Core.Configuration.Core;
using STARST.Mo.Core.Configuration.Repository;

namespace STARST.Mo.Core.Configuration
{
    /// <summary>
    /// Class to read configuration value from data store.
    /// </summary>
    internal class DBConfigurationRader : IConfigurationReader
    {
        private IConfigRepository _configRepository;

        public DBConfigurationRader() : this(new ConfigRepository())
        {
        }

        internal DBConfigurationRader(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
        }

        public string Get(string key)
        {
            _configRepository.GetConfigItems();
            return string.Empty;
        }
    }
}
