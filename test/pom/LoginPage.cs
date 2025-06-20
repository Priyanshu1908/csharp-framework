using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_framework.test.pom
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver) {
        
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        private readonly IWebElement username;

        public IWebElement getUsername() { return username; }

        [FindsBy(How =How.Id, Using = "password")]
        private readonly IWebElement password;

        public IWebElement getPassword() { return password; }

        [FindsBy(How = How.Id, Using = "signInBtn")]
        private readonly IWebElement signInButton;

        public IWebElement GetSignInButton() { return signInButton; }

        public ShopPage DoLogin(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            signInButton.Click();
            return new ShopPage(driver);
        }

    }
}
