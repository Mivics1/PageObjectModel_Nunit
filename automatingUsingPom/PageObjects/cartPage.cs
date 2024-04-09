using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class cartPage
    {
        private readonly IWebDriver driver;

        public cartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement checkoutButton => driver.FindElement(By.CssSelector(".checkout_button"));
        IWebElement cartPageTitle => driver.FindElement(By.CssSelector(".title"));
        IWebElement cartItemName => driver.FindElement(By.CssSelector(".inventory_item_name"));
        public void clickCheckoutButton()
        {
            checkoutButton.Click();
        }
        public void confirmCartName() {     
            if (cartItemName.Text != "Sauce Labs Bolt T-Shirt")
                {
                    Console.WriteLine("T-shirt details in cart are incorrect. Exiting...");
                    driver.Quit();
                    return;
                }
        }

        public void confirmCartPageTitle() { 
            if (cartPageTitle.Text != "Your Cart")
            {
                Console.WriteLine("Cart page not displayed. Exiting...");
                driver.Quit();
                return;
            }
        }

        }
}
