namespace Agilty.DataStorage
{
    using System.Configuration;

    #region Class: DataStorageConfiguration

    
    public class DataStorageConfiguration: ConfigurationSection
    {

        [ConfigurationProperty("Provider")]
        public string Provider {
            get { return (string)this["Provider"]; }
            set { this["Provider"] = value; }
        }

    }

    #endregion

}