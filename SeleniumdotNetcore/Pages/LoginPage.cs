using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumdotNetcore.Pages
{
    public class LoginPage : DriverHelper
    {

        IWebElement txtUserName => driver.FindElement(By.Id("UserName"));


        IWebElement txtPassword => driver.FindElement(By.Id("Password"));

        IWebElement btnLogin => driver.FindElement(By.XPath("//input[@type='submit']"));



        public void enterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);



        }


        public void ClickLogin()
        {

            btnLogin.Click();

        }
    }
}
