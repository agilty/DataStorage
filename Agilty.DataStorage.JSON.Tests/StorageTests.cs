namespace Agilty.DataStorage.JSON.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #region Class:

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
        public void LoadDataTest_()
        {
            var value = storage["TestTable.QX.Id"];
            Assert.AreEqual("qx id", value);
        }

        [TestMethod]
        [DeploymentItem(VALID_DATA_FILE)]
        public void LoadDataTest()
        {
            var x = Agilty.DataStorage.Storage.Current.Get("");
            var value = storage["TestTable.QX.Id"];
            Assert.AreEqual("qx id", value);
        }

        #endregion

        #region Methods: Static

        [TestInitialize]
        public void TestInitialize()
        {
            storage = new DataStorage.JSON.Storage(VALID_DATA_FILE);
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