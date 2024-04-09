using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatingUsingPom.PageObjects
{
    public class loginPage
    {
        private readonly IWebDriver driver;

        public loginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement userNameText => driver.FindElement(By.Id("user-name"));
        IWebElement passText => driver.FindElement(By.Id("password"));
        IWebElement loginButton => driver.FindElement(By.Id("login-button"));


        public void login(string username, string password)
        {
            userNameText.SendKeys(username);
            passText.SendKeys(password);
            loginButton.Submit();
        }
    }
}
