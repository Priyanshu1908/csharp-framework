using csharp_framework.lib;
using csharp_framework.lib.model;
using csharp_framework.test.pom;
using System.Diagnostics.CodeAnalysis;

namespace csharp_framework.test.sanity
{
    [Parallelizable, ExcludeFromCodeCoverage]
    internal class LoginTest : BaseTest
    {
        private readonly string Url = "https://rahulshettyacademy.com/loginpagePractise/";

        [Test, Category("Sanity"), Category("Web"), TestOf(nameof(TestType.Web))]
        [TestCase("rahulshettyacademy", "learning")]
        public void TestLogin(string username, string password)
        {
            Driver.Url = Url;
            LoginPage login = new LoginPage(Driver);
            ShopPage shop = login.DoLogin(username, password);
            var status = Utilities.TryAssert(() => Assert.IsTrue(shop.GetCheckoutButton().Displayed));

        }
    }
}
