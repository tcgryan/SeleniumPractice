using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNet.Pages
{
    public class LoginPage : DriverHelper
    { 
        IWebElement username => Driver.FindElement(By.XPath("//input[@id='UserName']"));
        IWebElement password => Driver.FindElement(By.XPath("//input[@id='Password']"));

        public void EnterLoginInfo()
        {
            username.SendKeys("User");
            password.SendKeys("Password");
        }
    }
}
