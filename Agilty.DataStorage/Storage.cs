namespace Agilty.DataStorage
{
    using System;
    using System.Configuration;
    using System.Text.RegularExpressions;

    #region Class: Storage

    public abstract class Storage : IStorage
    {

        #region Properties: Public

        private static IStorage _current;
        public static IStorage Current
        {
            get
            {
                if (_current == null)
                {
                    _current = Load();
                }
                return _current;
            }
        }

        public string this[string key]
        {
            get { return Get(key); }
        }

        #endregion

        #region Methods: Public

        public virtual string Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public virtual T Get<T>(string key)
        {
            return (T)Convert.ChangeType(Get(key), typeof(T));
        }

        #endregion

        #region Methods: Private

        private static IStorage Load()
        {
            var configuration = (DataStorageConfiguration)ConfigurationManager.GetSection("DataStorage");
            var regex = new Regex("(?<type>.*[^,]+), (?<assembly>.*)");
            if (regex.IsMatch(configuration.Provider))
            {
                var match = regex.Match(configuration.Provider);
                return (IStorage)AppDomain.CurrentDomain
                    .CreateInstanceAndUnwrap(match.Groups["assembly"].Value, match.Groups["type"].Value);
            }
            throw new Exception("Invalid Data Storage configuration");
        }

        #endregion

    }

    #endregion

}