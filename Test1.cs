using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SeleniumTask1
{
    /// <summary>
    /// 1. Create test 1, which goes to RMSys login page, login with correct credentials (Username – EugenBorisik, Password – qwerty12345, URL - https://192.168.100.26/).
    /// </summary>

    [TestClass]
    public class Test1
    {
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("https://192.168.100.26/");
            driver.FindElement(By.Id("Username")).SendKeys("EugenBorisik");
            driver.FindElement(By.Id("Password")).SendKeys("qwerty12345");
            driver.FindElement(By.Id("SubmitButton")).Click();
            Assert.AreEqual("RMSys - Home", driver.Title.ToString());
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}
