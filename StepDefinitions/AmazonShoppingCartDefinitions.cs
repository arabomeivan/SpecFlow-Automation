using NextBasketAssesment.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NextBasketAssesment.StepDefinitions
{
    [Binding]
    public sealed class AmazonShoppingCartDefinitions
    {
        HomePage HomePage;
        IWebDriver webDriver = new ChromeDriver();

        [Given(@"I am on Amazon home page as an unregistered user")]
        public void GivenIAmOnAmazonHomePageAsAnUnregisteredUser()
        {    
            // Maximize the browser window
            webDriver.Manage().Window.Maximize();

            Thread.Sleep(10000);

            webDriver.Navigate().GoToUrl("https://www.amazon.com/");
            
            Thread.Sleep(10000);

            HomePage = new HomePage(webDriver);
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string p0)
        {
            HomePage.SearchItem();
            HomePage.SubmitSearch();


        }

        [When(@"I add the item to my cart")]
        public void WhenIAddTheItemToMyCart()
        {
            Thread.Sleep(8000);
            HomePage.SelectedItem.Click();
            Thread.Sleep(8000);
            HomePage.AddItemToCart.Click();
            Thread.Sleep(5000);
            HomePage.GoToCart.Click();
        }
        [Then(@"item should be displayed in cart with the correct amount")]
        public void ThenItemShouldBeDisplayedInCartWithTheCorrectAmount()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("TP-LINK TL-WR940N Wireless N300 Home Router, 450Mpbs, 3 External Antennas, IP QoS, WPS Button", HomePage.GetProductName());
            Assert.AreEqual("$55.39", HomePage.GetProductPrice());
            webDriver.Quit();
        }


        

    }
}
