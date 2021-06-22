using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestTestTest.PageObjects
{

    class HomePage
    {
        private static IWebDriver driver;

        IWebElement signInBtn = driver.FindElement(By.ClassName("login"));

        public void clickSignInButton()
        {
            signInBtn.Click();
        }

    }
}
