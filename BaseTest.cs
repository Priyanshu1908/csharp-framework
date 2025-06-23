using csharp_framework.lib;
using NPOI.Util.Collections;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace csharp_framework
{
    [TestFixture]
    public class BaseTest
    {
        public static IWebDriver Driver => DriverManager.GetDriver();
        //public TestReport Report;
        private static readonly string Sep = Path.DirectorySeparatorChar.ToString();
        private static readonly string ConfigFilePath = Utilities.GetSolutionPath() + Sep + "config.ini";

        private static readonly string JsonFilePath = Utilities.GetSolutionPath() + Sep + "test/resources/TestData.json";

        [OneTimeSetUp]
        public void BeforeSuite()
        {
            
        }

        [SetUp]
        public void BeforeMethod()
        {
            DriverManager.InitializeBrowser(GetConfig()["browser"]);
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

        public string GetScreenshot() { 
        
            return ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
        }

        public static string GetJsonReader(string token)
        {
            return Utilities.ReadJson(JsonFilePath, token);
        }
    }
}
