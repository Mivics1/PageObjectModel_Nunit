using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class checkout_complete_page
    {
        private readonly IWebDriver driver;

        public checkout_complete_page(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement confirmationPageTitle => driver.FindElement(By.CssSelector(".complete-header"));
        public void confirmation() { 
        if (confirmationPageTitle.Text != "Thank you for your order")
            {
                driver.Quit();
                return;
            }
        }
    }
}
