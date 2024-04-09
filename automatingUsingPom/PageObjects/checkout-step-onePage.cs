using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class checkout_step_onePage
    {
        private readonly IWebDriver driver;

        public checkout_step_onePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement firstNameBox => driver.FindElement(By.Id("first-name"));
        IWebElement lastNameBox => driver.FindElement(By.Id("last-name"));
        IWebElement postalCodeBox => driver.FindElement(By.Id("postal-code"));
        IWebElement continueButton => driver.FindElement(By.Id("continue"));

        public void fillCheckoutInfo(string firstname, string lastname, string postalcode)
        {
            firstNameBox.SendKeys(firstname);
            lastNameBox.SendKeys(lastname);
            postalCodeBox.SendKeys(postalcode);
            continueButton.Submit();
        }
    }
}
