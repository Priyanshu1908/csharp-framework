using csharp_framework.lib;
using NPOI.Util.Collections;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace csharp_framework
{
    [TestFixture]
    public class BaseTest
    {
        public WebDriver Driver;
        
        private static readonly string ConfigFilePath = Utilities.GetSolutionPath() + "/" + "config.ini";

        [OneTimeSetUp]
        public void BeforeSuite()
        {
            
        }

        [SetUp]
        public void BeforeMethod()
        {
            Driver = DriverManager.InitializeBrowser(GetConfig()["browser"]);
        }

        [TearDown]
        public void AfterMethod()
        {
            Driver.Close();
        }

        [OneTimeTearDown]
        public void AfterSuite()
        {

        }

        Properties GetConfig() => Utilities.GetConfig(ConfigFilePath);
    }
}
