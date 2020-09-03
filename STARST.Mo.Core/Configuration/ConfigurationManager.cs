using System;
using STARST.Mo.Core.Configuration.Core;

namespace STARST.Mo.Core.Configuration
{
    /// <summary>
    ///  This class inherits from IConfigurationManager. 
    ///  It is an entry point that helps in retrieving the data from the configuration data store based on the user's request.
    ///  It caches all the configuration values and fetches the data from the cached value based on the user request.
    ///  The cache value would be refreshed, when the Message Queue is notifies to the configuration manager
    ///  Data can be retrieved by single value depends on caller's demand.
    /// </summary>
    public class ConfigurationManager : IConfigurationManager
    {
        private static IConfigurationManager _instance = new ConfigurationManager();

        public static IConfigurationManager Instance
        {
            get
            {
                return _instance;
            }
        }

        internal IConfigurationReader Reader
        {
            get
            {
                return ConfigurationReaderFactory.GetConfigReader(ConfigReaderType.DatabaseReader);
            }
        }

        public T GetValue<T>(string key)
        {
            var value = default(T);

            var readerValue = Reader.Get(key);
            value = ConvertType<T>(readerValue);
            return value;
        }

        private static T ConvertType<T>(string value)
        {
            var type = typeof(T);
            return (T)Convert.ChangeType(value, type);
        }
    }
}
