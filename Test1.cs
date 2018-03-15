using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SeleniumTask1
{
    [TestClass]
    public class Test1
    {
        IWebDriver driver = new ChromeDriver();
        //FirefoxDriver driver = new FirefoxDriver();
        [TestMethod]
        public void TestMethod1()
        {

            driver.Navigate().GoToUrl("https://192.168.100.26/");
            driver.FindElement(By.Id("Username")).SendKeys("EugenBorisik");
            driver.FindElement(By.Id("Password")).SendKeys("qwerty12345");
            driver.FindElement(By.Id("SubmitButton")).Click();
            Console.WriteLine("URL: " + driver.Url.ToString());
            Console.WriteLine("Title: " + driver.Title.ToString());

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(driver.Url.ToString().Contains("192.168.100.26") && (driver.Title.ToString() == "RMSys - Home"));
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            // 2. Create test 2, which perform logout from RMSys.
            //driver.FindElementByLinkText("Sign Out").Click(); 
            driver.Quit();
        }
    }
}
