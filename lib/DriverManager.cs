using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace csharp_framework.lib
{
    public class DriverManager
    {
        public static WebDriver InitializeBrowser(string browser)
        {
            ThreadLocal<WebDriver> webDriver = new ThreadLocal<WebDriver>();
            WebDriver driver;

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
            return driver;
        }
    }
}
