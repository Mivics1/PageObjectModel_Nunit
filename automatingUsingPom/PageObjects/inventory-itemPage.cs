using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class inventoryItemPage
        {
            private readonly IWebDriver driver;

            public inventoryItemPage(IWebDriver driver)
            {
                this.driver = driver;
            }

            IWebElement inventoryItemPages => driver.FindElement(By.CssSelector(".inventory_details_name"));
            IWebElement addCartButton => driver.FindElement(By.CssSelector(".btn_inventory"));
            IWebElement cartBadge => driver.FindElement(By.CssSelector(".shopping_cart_badge"));
            IWebElement cartItems => driver.FindElement(By.CssSelector(".shopping_cart_link"));


            public void itemDisplayed()
                {
                    if (!inventoryItemPages.Displayed) {
                        Console.WriteLine("T-shirt details page not displayed. Exiting...");
                        driver.Quit();
                        return;
                    }
                }
            public void addToCart()
            {
                addCartButton.Click();
            }

            public void confirmCartBadge() { 
                if (cartBadge.Text != "1")
                {
                    Console.WriteLine("T-shirt not added to cart. Exiting...");
                    driver.Quit();
                    return;
                }
            }

            public void checkCartItems()
            {
                cartItems.Click();
            }
    }
}
