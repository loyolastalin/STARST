using STARST.Mo.Core.Configuration.Core;

namespace STARST.Mo.Core.Configuration
{
    /// <summary>
    /// Creates an instance of configuration reader for specified reader type provided by the caller.
    /// </summary>
    internal class ConfigurationReaderFactory
    {
        private ConfigurationReaderFactory()
        {
        }

        internal static IConfigurationReader GetConfigReader(ConfigReaderType configReaderType)
        {
            switch (configReaderType)
            {
                case ConfigReaderType.DatabaseReader:
                    return new DBConfigurationRader();
            }

            return null;
        }
    }
}
