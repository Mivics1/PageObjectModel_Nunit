using automatingUsingPom.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automatingUsingPom
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            // Step 1: Navigate to the Sauce Labs Sample Application (https://www.saucedemo.com/) in Incognito mode.
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            _driver = new ChromeDriver(options);

            //Maximize the browser window for better view
            _driver.Manage().Window.Maximize();

            // Navigate to Sauce Labs Sample Application
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void usingPomNunit()
        {
            //Input log details and submit
            loginPage loginpage = new loginPage(_driver);
            loginpage.login("standard_user", "secret_sauce");
            //Confirms the loginPage 
            string currentUrl = _driver.Url;
            Assert.That(currentUrl.Contains("inventory"));
            //Select Tshirt
            inventoryPage inventorypage = new inventoryPage(_driver);
            inventorypage.selectTShirt();
            Thread.Sleep(1000);
            // Verify that the T-shirt details page is displayed.
            inventoryItemPage inventoryItemPage = new inventoryItemPage(_driver);
            inventoryItemPage.itemDisplayed();
            inventoryItemPage.addToCart();
            inventoryItemPage.confirmCartBadge();
            inventoryItemPage.checkCartItems();
            Thread.Sleep(1000);
            cartPage cartpage = new cartPage(_driver);
            cartpage.confirmCartPageTitle();
            cartpage.confirmCartName();
            Thread.Sleep(1000);
            cartpage.clickCheckoutButton();
            Thread.Sleep(1000);
            checkout_step_onePage checkout_step_one = new checkout_step_onePage(_driver);
            checkout_step_one.fillCheckoutInfo("Agboola", "Daramola", "NG");
            Thread.Sleep(1000);
            checkout_step_twoPage checkout_step_two = new checkout_step_twoPage(_driver);
            checkout_step_two.verifyOrder();
            Thread.Sleep(1000);
            checkout_complete_page checkout_complete = new checkout_complete_page(_driver);
            checkout_complete.confirmation();
            Thread.Sleep(1000);
        }
        [TearDown]
        public void Dispose()
        {
                this._driver.Quit();
                this._driver.Dispose();
        }
    }

}