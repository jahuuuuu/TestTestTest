using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestTestTest.PageObjects
{
    class AuthenticationPage
    {
        private static IWebDriver driver;

        IWebElement emailSignIn = driver.FindElement(By.Id("email"));
        IWebElement passwordSignIn = driver.FindElement(By.Id("passwd"));
        IWebElement signInBtn = driver.FindElement(By.Id("SubmitLogin"));
        IWebElement error = driver.FindElement(By.XPath("//p[text()="There is 1 error"]/following::ol/li"));

        public void fillIncorrectDataForSignIn()
        {
            emailSignIn.Click();
            emailSignIn.SendKeys("jakistamemail@gmail.com");
            passwordSignIn.Click();
            passwordSignIn.SendKeys("qwerty123");
            signInBtn.Click();
        }

        public void assertErrorMessage()
        {
            String ExpectedMessage = "Authentication failed.";
            Assert.AreEqual(ExpectedMessage, error, "Different URLs");

        }
    }
}
