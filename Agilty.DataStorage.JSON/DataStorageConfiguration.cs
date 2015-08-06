namespace Agilty.DataStorage.JSON
{
    using System.Configuration;

    #region Class: DataStorageConfiguration

    public class DataStorageConfiguration: ConfigurationSection
    {

        #region Properties: Public

        [ConfigurationProperty("DataFile")]
        public string DataFile {
            get { return (string)this["DataFile"]; }
            set { this["DataFile"] = value; }
        }

        #endregion

    }

    #endregion

}