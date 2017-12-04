using OpenQA.Selenium;

namespace MyFramework.Page_Objects
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Method is filling username and password and clicks login button
        /// </summary>
        /// <param name="username">username input</param>
        /// <param name="password">password input</param>
        /// <returns>True if logging was successfull</returns>
        public bool Login(string username, string password)
        {
            driver.FindElement(By.Name("loginForm.login")).SendKeys(username);
            driver.FindElement(By.Name("loginForm.password")).SendKeys(password);
            driver.FindElement(By.Name("ok")).Click();

            if (driver.FindElement(By.XPath("//a[@rel='nofollow']")).Text.Equals(username))
            {
                return true;
            }

            driver.FindElement(By.Name("loginForm.login")).Clear();
            return false;          
        }



    }
}
