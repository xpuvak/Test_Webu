using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            bool isPageOnline = driver.FindElement(By.TagName("body")).Displayed;
            Assert.IsTrue(isPageOnline, "Page is offline");
            driver.Quit();
        }
    }
}