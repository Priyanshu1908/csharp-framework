namespace csharp_framework.test.unit
{
    [Category("Unit")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Inside SetUp");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Inside Test1");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Inside Test2");
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Progress.WriteLine("Inside TearDown");
        }
    }
}