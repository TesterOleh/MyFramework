using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyFramework
{
    public class BaseTest
    {
        public IWebDriver driver; 
        
        [SetUp]
        public void BornChromeDriver()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void DieChromeDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
