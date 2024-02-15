using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace NextBasketAssesment.Pages
{
    public class HomePage
    {
        public IWebDriver webDriver { get; }
        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement SearchField => WebDriver.FindElement(By.Name("field-keywords"));

        public IWebElement SelectedItem => WebDriver.FindElement(By.LinkText("TL-WR940N Wireless N300 Home Router, 450Mpbs, 3 External Antennas, IP QoS, WPS Button"));

        public IWebElement AddItemToCart => WebDriver.FindElement(By.XPath("/html/body/div[1]/div/div[10]/div[5]/div[1]/div[6]/div/div[1]/div/div/div/form/div/div/div/div/div[4]/div/div[16]/div[1]/span/span/span/input"));
        public IWebElement GoToCart => WebDriver.FindElement(By.Id("nav-cart"));
        public IWebElement ProductNameElement => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div[4]/div/div[2]/div[1]/div/form/div[2]/div[3]/div[4]/div/div[2]/ul/li/span/a/span[1]/span/span[2]"));
        public IWebElement ProductPriceElement => WebDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div[4]/div/div[2]/div[1]/div/form/div[2]/div[3]/div[4]/div/div[2]/ul/div[1]/div[1]/div/div/span"));
        
        public IWebDriver WebDriver { get; }

        public void SubmitSearch() => SearchField.SendKeys(Keys.Enter);

        public void SearchItem() => SearchField.SendKeys("TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)");

        public string GetProductName()
        {
            // Get the text of the productNameElement
            string productName = ProductNameElement.Text;
            return productName;
        }

        public string GetProductPrice()
        {
           
            string productPrice = ProductPriceElement.Text;
            return productPrice;
        }

    }
}
