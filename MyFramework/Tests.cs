using NUnit.Framework;

namespace MyFramework
{
    class Tests : BaseTest
    {
        [Test]
        public void FirstTest()
        {
            driver.Navigate().GoToUrl("http://google.com");

            Assert.AreEqual("Google",driver.Title);
        }
    }
}
