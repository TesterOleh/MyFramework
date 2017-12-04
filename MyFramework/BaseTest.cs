using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MyFramework
{
    public class BaseTest
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void BornChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void DieChromeDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
