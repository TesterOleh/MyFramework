using NUnit.Framework;
using OpenQA.Selenium;

namespace MyFramework.Page_Objects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Mehtod navigates to Homa page and check navigtion is correct
        /// </summary>
        /// <returns>Home page with web driver - can be used by next method</returns>
        public HomePage Open()
        {
            driver.Navigate().GoToUrl("http://www.quizful.net/");
            Assert.AreEqual("http://www.quizful.net/test", driver.Url); 
            Assert.AreEqual("Quizful - тесты онлайн", driver.Title);
            return new HomePage(driver);
        }

        /// <summary>
        /// Method clicks on login link at Home page and check if navigation is correct
        /// </summary>
        /// <returns>Login page with web driver - can be used by next method</returns>
        public LoginPage ClickLogin()
        {
            driver.FindElement(By.LinkText("войти")).Click();
            Assert.AreEqual("http://www.quizful.net/LoginAction.loginForm", driver.Url);
            Assert.AreEqual("Вход в систему", driver.FindElement(By.XPath("//div[@id='login-form']/div[@class='title']")).Text);
            return new LoginPage(driver);
        }
    }
}
