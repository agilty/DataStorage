namespace Agilty.DataStorage.JSON.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #region Class: StorageTests

    [TestClass]
    public class StorageTests
    {

        #region Constants: Private

        private const string VALID_DATA_FILE = "valid_data_file.json";
        private const string INVALID_DATA_FILE = "invalid_data_file.json";
        private const string NOT_EXISTING_DATA_FILE = "not_existing.json";

        #endregion

        #region Fields: Private

        IStorage storage;

        #endregion

        #region Properties: Public

        private TestContext _testContext;
        public TestContext TestContext
        {
            get
            {
                return _testContext;
            }
            set
            {
                _testContext = value;
            }
        }

        #endregion

        #region Methods: Public

        [TestMethod]
        [DeploymentItem(VALID_DATA_FILE)]
        [DeploymentItem("Agilty.DataStorage.JSON.dll")]
        public void LoadDataTest()
        {
            var value = Storage.Current["TestTable.QX.Id"];
            Assert.AreEqual("qx id", value);
        }

        #endregion

        #region Methods: Static

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
            storage = null;
        }

        #endregion

    }

    #endregion

}