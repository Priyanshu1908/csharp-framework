using OpenQA.Selenium;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace csharp_framework.test.sanity
{
    [Parallelizable, ExcludeFromCodeCoverage]
    internal class HelloWorld : BaseTest
    {
        [Test, Category("Sanity")]
        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
