using OpenQA.Selenium;
using System.Diagnostics;

namespace csharp_framework.test.sanity
{
    [Parallelizable]
    internal class HelloWorld : BaseTest
    {
        [Test, Category("Sanity")]
        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Debug.WriteLine("Hello Priyanshu");
            string name = "Priyanshu Rathore";
            Console.WriteLine($"Hi {name}");
        }
    }
}
