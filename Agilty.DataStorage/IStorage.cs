namespace Agilty.DataStorage
{

    #region Interface: Public

    public interface IStorage
    {

        #region Properties: Public

        string this[string key] { get; }

        #endregion

        #region Methods: Public

        string Get(string key);

        T Get<T>(string key);

        #endregion

    }

    #endregion

}