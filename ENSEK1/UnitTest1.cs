using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ENSEK1
{
    [TestClass]
    public class UnitTest1
    {


        [TestInitialize]


        [TestMethod]
        public void BuyEnergy()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ensekautomationcandidatetest.azurewebsites.net/");
            driver.Manage().Window.Maximize();


            IWebElement BuyEnergyBtn = driver.FindElement(By.LinkText(("Buy energy »")));
            BuyEnergyBtn.Click();

            IWebElement Title = driver.FindElement(By.XPath("//h2[contains(text(),'Buy Energy')]"));
            Assert.IsTrue(driver.FindElement(By.XPath("//h2[contains(text(),'Buy Energy')]")).Displayed);

            IWebElement uName = driver.FindElement(By.Id("energyType_AmountPurchased"));
            uName.SendKeys("100");

            IWebElement BuyBtn = driver.FindElement(By.Name("Buy"));
            BuyBtn.Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//h2[contains(text(),'Sale Confirmed!')]")).Displayed);
        }
     }
}
