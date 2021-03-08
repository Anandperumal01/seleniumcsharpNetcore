using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumdotNetcore.Pages
{
    class HomePage :DriverHelper
    {

        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));
        
        IWebElement lnkLogoff => driver.FindElement(By.LinkText("Log off"));

        public void clickLogin() => lnkLogin.Click();

        public bool isLogoffExist() => lnkLogoff.Displayed;
    }
}
