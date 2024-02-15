using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace NextBasketAssesment.Pages
{
    public class Page
    {
        public IWebDriver webDriver { get; }
        public Page(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement SearchField => WebDriver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement SearchButton => WebDriver.FindElement(By.Id("nav-search-submit-button"));

        public IWebDriver WebDriver { get; }

        public void SubmitSearch() => SearchField.SendKeys(Keys.Enter);

        public void SearchItem() => SearchField.SendKeys("TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)");
        //public bool isProfileNameExist() => ProfileName.Displayed;

    }
}
