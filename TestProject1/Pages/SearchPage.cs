using OpenQA.Selenium;

namespace TestProject1.Pages
{
    internal class SearchPage : BasePage
    {

        public SearchPage(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement currencyElement => WaitForElementVisible("//span[@class='a-price']//span[@aria-hidden='true']/span[@class='a-price-symbol']");
        public IWebElement dollarElement => WaitForElementVisible("//span[@class='a-price']//span[@aria-hidden='true']/span[@class='a-price-whole']");
        public IWebElement centElement => WaitForElementVisible("//span[@class='a-price']//span[@aria-hidden='true']/span[@class='a-price-fraction']");

        public string TakeSearchPrice()
        {
            string currency = currencyElement.Text;
            string dollars = dollarElement.Text;
            string cents = centElement.Text;

            string price = currency + " " + dollars + "." + cents;

            return price;
        }

    }
}
