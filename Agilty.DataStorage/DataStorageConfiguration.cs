namespace Agilty.DataStorage
{
    using System.Configuration;

    #region Class: DataStorageConfiguration


    public class DataStorageConfiguration : ConfigurationSection
    {

        #region Properties: Public

        [ConfigurationProperty("Provider")]
        public string Provider
        {
            get { return (string)this["Provider"]; }
            set { this["Provider"] = value; }
        }

        #endregion

    }

    #endregion

}