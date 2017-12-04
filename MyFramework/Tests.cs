using System;
using System.IO;
using MyFramework.Page_Objects;

namespace MyFramework
{
    class Tests : BaseTest
    {

        static void Main(string[] args)
        {
            Tests tests = new Tests();

            tests.BornDriver();

            tests.Test();

            tests.DieDriver();
        }

        public void Test()
        {
            string username;
            string password;

            HomePage PageHome = new HomePage(driver);

            PageHome.Open().ClickLogin();

            LoginPage PageLogin = new LoginPage(driver);

            using (StreamWriter file = new StreamWriter(@"brute-force_results.csv", true))
            {
                for (int i = 1; i < 1000; i++)
                {
                    username = "temp" + i;
                    password = "temp" + i;
                    Console.Write("try: " + username+","+password);
                    if (PageLogin.Login(username, password))
                    {
                        file.WriteLine(username + ',' + password);
                        Console.WriteLine(" - successfull login !!!");
                        PageHome.ClickLogout();
                    }
                    else
                    {
                        Console.WriteLine(" - fail to login");
                    }
                }
            }        
        }
    }
}
