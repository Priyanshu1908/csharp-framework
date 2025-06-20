using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_framework.test.pom
{
    public class ShopPage
    {
        IWebDriver driver;

        public ShopPage(IWebDriver driver) { 
        
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Checkout')]")]
        IWebElement checkoutButton;

        public IWebElement GetCheckoutButton() { return checkoutButton; }
    }
}
