using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;

namespace MyFramework
{
    public class BaseTest
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public void BornDriver()
        {

            Console.Write("Choose browser:\n1) Chrome\n2) Firefox\n3) PhatomJS\nYour choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": driver = new ChromeDriver();
                    break;
                case "2": driver = new FirefoxDriver();
                    break;
                case "3": driver = new PhantomJSDriver();
                    break;
                default: Console.WriteLine("Incorrect selection. We will use Chrome now. Please press any key to continue...");
                    Console.ReadLine();
                    driver = new ChromeDriver();
                    break;          
            }

            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void DieDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
