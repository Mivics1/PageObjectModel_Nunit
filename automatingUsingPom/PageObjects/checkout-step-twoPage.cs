using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class checkout_step_twoPage
    {
        private readonly IWebDriver driver;

        public checkout_step_twoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement checkoutInfoPageTitle => driver.FindElement(By.CssSelector(".title"));
        IWebElement totalPageTitle => driver.FindElement(By.CssSelector(".summary_total_label"));
        IWebElement cartItemNameConfirm => driver.FindElement(By.CssSelector(".inventory_item_name"));
        IWebElement finishButton => driver.FindElement(By.Id("finish"));

        public void verifyOrder()
        {
            if (checkoutInfoPageTitle.Text != "Checkout: Your Information" && totalPageTitle != null && cartItemNameConfirm.Text != "Sauce Labs Bolt T-Shirt")
            {
                Console.WriteLine("Summary page not displayed. Exiting...");
                driver.Quit();
                return;
            }
            finishButton.Submit();
        }
    }
}
