using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class UnitTest1
    {
        private IWebDriver driver;
        public UnitTest1()
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            ChromeOptions chromeOptions = new();
            chromeOptions.AddArguments("headless");

            driver = new ChromeDriver(chromeDriverService, chromeOptions);
            //driver.Manage().Window.Maximize();
        }
        public string TakePrice(string URL, string language, string product)
        {

            BasePage Page = new BasePage(driver);
            Page.homePage.OpenPage(URL);
            
            Page.deliveryPage.GoSelectCountryDelivery(language);

            Page.homePage.EnterSearchText(product);

            string productPrice = Page.searchPage.TakeSearchPrice();

            return productPrice;
        }


        // Для швидкої перевірки методу!
        //[Test]
        public void hiMe()
        {
            string non1 = "https://www.amazon.com/";
            string non2 = "Togo";
            string non3 = "Hi Me! ^^ ";
            string non4 = TakePrice(non1,non2,non3);
            Console.WriteLine(non4);

        }
    }
}