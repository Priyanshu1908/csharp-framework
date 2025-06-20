using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace csharp_framework.lib
{
    public class DriverManager
    {
        private static ThreadLocal<IWebDriver> webDriver = new ThreadLocal<IWebDriver>();

        public static IWebDriver GetDriver() => webDriver.Value;
        public static void InitializeBrowser(string browser)
        {
            IWebDriver driver;

            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("Unsupported Browser");
            }
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            webDriver.Value = driver;
        }
    }
}
