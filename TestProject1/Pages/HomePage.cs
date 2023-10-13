using OpenQA.Selenium;

namespace TestProject1.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public IList<IWebElement> FindLanguageElements()
        {
            return FindElementsByXPath("//span[contains(@class,'flag-lop')]");
        }

        public void OpenPage(string page)
        {
            driver.Navigate().GoToUrl(page);
            while (FindLanguageElements().Count == 0)
            {
                driver.Navigate().Refresh();
                Thread.Sleep(TimeSpan.FromSeconds(3));
            }
        }
        public IWebElement DeliveryWind => WaitForElementClickable("//div[@id='glow-ingress-block']");
        public IWebElement SearchBox => WaitForElementClickable("//input[contains(@id,'twotabsearchtextbox')]");
        public IWebElement SearchBoxEnter => WaitForElementVisible("//input[contains(@id,'nav-search-submit-button')]");

        public void EnterSearchText(string searchText)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(searchText);
            SearchBoxEnter.Click();
        }
    }
}
