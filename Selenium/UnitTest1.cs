namespace Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           TestContext.Progress.WriteLine("Setup method execution");
        }

        [Test]
        public void Test1()
        {
          TestContext.Progress.WriteLine("This is Test 1 method called");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is test 2 method called");
        }
        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("This is teardown methid called");

        }
    }
}