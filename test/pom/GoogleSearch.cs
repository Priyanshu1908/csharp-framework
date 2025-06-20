using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_framework.test.pom
{
    /// <summary>
    /// Google Search Page Class
    /// </summary>
    public class GoogleSearch
    {
        private IWebDriver driver;
        
        /// <summary>
        /// Google Search Page Constructor
        /// </summary>
        /// <param name="driver"></param>
        public GoogleSearch(IWebDriver driver) { 
            
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        IWebElement searchInput;

        public IWebElement getSearchInput()
        {
            return searchInput;
        }
    }
}
