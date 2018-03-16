using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTask1
{
    /// <summary>
    /// 2. Create test 2, which perform logout from RMSys.
    /// 3. Modify test 2: add extra assertion, which will be assert, that current URL contains the following part – “192.168.100.26”.
    /// </summary>
    [TestClass]
    public class Test2
    {
        IWebDriver driver = new ChromeDriver();
        public Test2()
        {
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("https://192.168.100.26/");
            driver.FindElement(By.Id("Username")).SendKeys("EugenBorisik");
            driver.FindElement(By.Id("Password")).SendKeys("qwerty12345");
            driver.FindElement(By.Id("SubmitButton")).Click();
            Console.WriteLine("URL: " + driver.Url.ToString());
            Console.WriteLine("Title: " + driver.Title.ToString());
            Assert.IsTrue(driver.Url.ToString().Contains("192.168.100.26") && (driver.Title.ToString() == "RMSys - Home"));
            driver.FindElement(By.LinkText("Sign Out")).Click();
        }
        [TestCleanup()]
        public void MyTestCleanup()
        {

            driver.Quit();
        }
    }
}
