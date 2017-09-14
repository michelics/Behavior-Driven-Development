using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Configuration;

namespace UnitTestProject
{
    [Binding]
    public class SearchPlace_ByDestinationAndPeriodSteps
    {
        IWebDriver Browser;

        [BeforeScenario]
        public void CreateWebDriver()
        {
            //Create a browser instance before execute the scenarios
            this.Browser = new ChromeDriver();
        }

        [AfterScenario]
        public void CloseWebDriver()
        {
            //Close the browser after finished the scenarios
            this.Browser.Close();
            this.Browser.Dispose();
        }
        
        [Given(@"I am access the application")]
        public void GivenIAmAccessTheApplication()
        {
            //Navigate to URL 
            this.Browser.Navigate().GoToUrl("https://www.booking.com/index.html");
        }
        
        [Given(@"I have opened Accommodations Page")]
        public void GivenIHaveOpenedAccommodationsPage()
        {
            Assert.IsTrue(this.Browser.FindElement(By.XPath("//*[@id=\"cross-product-bar\"]/strong/span")).Text.Contains("Accommodations"));
        }

        [When(@"I search by field (.*)")]
        public void WhenISearchByField(string destination)
        {
            this.Browser.FindElement(By.XPath("//*[@id=\"ss\"]")).SendKeys(destination);
            this.Browser.FindElement(By.XPath("//*[@id=\"frm\"]/div[6]/div[2]/button/span[1]")).Click();
        }
        
        [Then(@"the page returns record found")]
        public void ThenThePageReturnsRecordFound()
        {
            Assert.IsTrue(this.Browser.FindElement(By.XPath("//*[@id=\"right\"]/div[3]/div/div/div/h1")).Text.Contains("properties found"));
            
        }
    }
}
