using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class inventoryPage
    {
        private readonly IWebDriver driver;

        public inventoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement inventoryPageTitle => driver.FindElement(By.ClassName("title"));
        IWebElement shirtLocation => driver.FindElement(By.CssSelector(".inventory_item:nth-child(3) .inventory_item_img"));

        public void selectTShirt()
        {
            shirtLocation.Click();
        }
    }
}
