using System.Threading;
using MyFramework.Page_Objects;
using NUnit.Framework;

namespace MyFramework
{
    class Tests : BaseTest
    {
        [Test]
        public void FirstTest()
        {

            HomePage PageHome = new HomePage(driver);
            PageHome.Open().
                ClickLogin();

            LoginPage PageLogin = new LoginPage(driver);
            PageLogin.Login("username","password");
            Thread.Sleep(3000);
            PageLogin.ClearUsernameField();
            PageLogin.Login("newuser", "password");
            Thread.Sleep(5000);



            //wait.Until(ExpectedConditions.ElementToBeClickable(Password));
            //By searchBox
        }
    }
}
