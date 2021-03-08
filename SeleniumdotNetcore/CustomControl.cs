using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumdotNetcore
{
    public class CustomControl : DriverHelper
    {


        public static void comboBox(string controlName, string value)
        {
            IWebElement comobobox = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comobobox.Clear();
            comobobox.SendKeys("Almond");
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
