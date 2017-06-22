using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumInDotNetCore2P1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var capabilities = DesiredCapabilities.InternetExplorer();

            var driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Users\rschi\Source\Repos\ConsoleApp1\ConsoleApp1");

            driver.Navigate().GoToUrl("http://www.google.com/ncr");

            Console.WriteLine(driver.Title);



            IWebElement query = driver.FindElement(By.Name("q"));

            query.SendKeys("TestingBot");

            query.Submit();

            Console.WriteLine(driver.Title);



            driver.Quit();
        }
    }
}
