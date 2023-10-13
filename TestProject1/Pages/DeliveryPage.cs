using OpenQA.Selenium;

namespace TestProject1.Pages
{
    internal class DeliveryPage : BasePage
    {
        public DeliveryPage(IWebDriver driver) : base(driver) 
        { 
        }
        public IWebElement ArrowCountries => WaitForElementVisible("//span[@data-action='a-dropdown-button']");
        public IWebElement ButtonDone => WaitForElementVisible("//button[@name='glowDoneButton']");

        public void GoSelectCountryDelivery(string countrie)
        {
            homePage.DeliveryWind.Click();
            ArrowCountries.Click();
            IWebElement ChoiceCountries = WaitForElementClickable($"//select[@id='GLUXCountryList']//*[.='{countrie}']");
            ChoiceCountries.Click();
            ButtonDone.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
