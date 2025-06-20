using csharp_framework.lib;
using csharp_framework.lib.model;
using csharp_framework.test.pom;
using OpenQA.Selenium;
using System.Diagnostics.CodeAnalysis;

namespace csharp_framework.test.sanity
{
    [Parallelizable, ExcludeFromCodeCoverage]
    internal class WebUITest : BaseTest
    {
        [Test, Category("Sanity"), Category("Web"), TestOf(nameof(TestType.Web))]
        public void WebTest()
        {
            Driver.Url = "https://www.google.com/";
            string title = Driver.Title;
            GoogleSearch googlePage = new GoogleSearch(Driver);
            googlePage.getSearchInput().SendKeys("test");
            Thread.Sleep(2000);
            var status = Utilities.TryAssert(() => Assert.That(title, Is.EqualTo("Google")));
            //Report.AddEvidence(new TestEvidence()
            //{
            //    Expected = "Page Title Contains 'Google'",
            //    Actual = "Page url did" + (status == TestStatus.Passed ? " " : " not ") + "contains string 'Google",
            //    StepStatus = status,
            //    Details = "Validate the web application",
            //    Screenshot = GetScreenshot(),
            //    StepName = "Test web UI",
            //    TestType = TestType.Web
            //});
        }
    }
}
