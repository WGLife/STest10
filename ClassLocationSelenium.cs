using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTask1
{
    public class ClassLocationSelenium
    {
        public IWebDriver webDriver;
        public ClassLocationSelenium()
        {

        }

        public void FindWebElementByID(string id)
        {

            webDriver.FindElements(By.Id(id));
        }

        public void FindWebElementByName(string name)
        {

            webDriver.FindElement(By.Name(name));
        }

        public void FindWebElementByClassName(string className)
        {

            webDriver.FindElement(By.ClassName(className));
        }

        public void FindWeElementByCssSelector(string selector)
        {
            webDriver.FindElement(By.CssSelector(selector));
        }

        public void FindWebElemenByTagName(string tagName)
        {

            IReadOnlyList<IWebElement> elements = webDriver.FindElements(By.TagName(tagName));
        }

        public void FindWebElementByLinkText(string linkText)
        {
            webDriver.FindElement(By.LinkText(linkText));
        }

        public void FindWebElementByPartialLinkText(string partialLinkText)
        {
            webDriver.FindElement(By.PartialLinkText(partialLinkText));
        }

        public void FindWebElementByXPath(string xPath)
        {
            webDriver.FindElement(By.XPath(xPath));
        }
    }
}
