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

        [TestMethod]
        public void LoginTest2()
        {
            driver.Navigate().GoToUrl("https://192.168.100.26/");
            driver.FindElement(By.Id("Username")).SendKeys("EugenBorisik");
            driver.FindElement(By.Id("Password")).SendKeys("qwerty12345");
            driver.FindElement(By.Id("SubmitButton")).Click();   
            Assert.IsTrue(driver.Url.ToString().Contains("192.168.100.26"));
            Assert.AreEqual("RMSys - Home",driver.Title.ToString());
            driver.FindElement(By.LinkText("Sign Out")).Click();
            Assert.AreEqual("RMSys - Sign In", driver.Title.ToString());
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
    }
}
