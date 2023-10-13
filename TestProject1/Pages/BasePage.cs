using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace TestProject1.Pages
{
    internal class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        protected IWebElement WaitForElementVisible(string locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        protected IWebElement WaitForElementClickable(string locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        protected IList<IWebElement> FindElementsByXPath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }

        //___________

        public DeliveryPage deliveryPage => new(driver);
        public HomePage homePage => new(driver);
        public SearchPage searchPage => new(driver);

    }
}
