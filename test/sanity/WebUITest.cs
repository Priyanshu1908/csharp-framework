using OpenQA.Selenium;

namespace csharp_framework.test.sanity
{
    [Parallelizable]
    internal class WebUITest : BaseTest
    {
        [Test, Category("Sanity"), Category("Web")]
        public void WebTest()
        {
            Driver.Url = "https://www.google.com/";
            string title = Driver.Title;
            Driver.FindElement(By.Name("q")).SendKeys("test");
            Thread.Sleep(2000);
            Assert.That(title, Is.EqualTo("Google"));        
        }
    }
}
