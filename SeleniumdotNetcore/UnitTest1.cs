using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumdotNetcore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = (@"C:\Program Files\Google\Chrome\Application\chrome.exe");

            driver = new ChromeDriver(options);

            Console.WriteLine("SeupMethod");
        }

        [Test]
        public void Test1()

        {
            driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            //string comobcontrolName = "AllMealsCombo";
            CustomControl.comboBox("AllMealsCombo", "Almonds");

          



            Assert.Pass();
            driver.Close();
        }
    }
}