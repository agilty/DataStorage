namespace Agilty.DataStorage.JSON
{
    using System.Configuration;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.IO;
    using System.Text.RegularExpressions;

    #region Class: Storage

    public class Storage : Agilty.DataStorage.Storage
    {

        #region Constructors: Public

        public Storage()
        {
            _dataFilePath = ((DataStorageConfiguration)ConfigurationManager.GetSection("DataStorage.JSON")).DataFile;
        }

        public Storage(string dataFilePath)
        {
            _dataFilePath = dataFilePath;
        }

        #endregion

        #region Properties: Private

        private readonly string _dataFilePath;

        private JObject _data;
        private JObject data
        {
            get
            {
                if (_data == null)
                {
                    using (var reader = new StreamReader(_dataFilePath))
                    {
                        _data = JsonConvert.DeserializeObject<JObject>(reader.ReadToEnd());
                        reader.Close();
                    }
                }
                return _data;
            }
        }

        #endregion

        #region Methods: Public

        public override string Get(string key)
        {
            var regex = new Regex(@"(?<table>.*)\.(?<schema>.*)\.(?<column>.*)");
            var matches = regex.Match(key);
            var table = data[matches.Groups["table"].Value];
            return data[matches.Groups["table"].Value][matches.Groups["schema"].Value][matches.Groups["column"].Value].Value<string>();
        }

        #endregion

    }

    #endregion

}