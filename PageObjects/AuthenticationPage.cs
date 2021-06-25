using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestTestTest.PageObjects
{
    class AuthenticationPage
    {
        private IWebDriver driver;
        Int32 timeout = 10000;

        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement authEmail;

        [FindsBy(How = How.Id, Using = "passwd")]
        [CacheLookup]
        private IWebElement authPassword;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        [CacheLookup]
        private IWebElement signInBTN;

        [FindsBy(How = How.Id, Using = "//p[text()='There is 1 error']/following::ol/li")]
        [CacheLookup]
        private IWebElement errorMSG;

        public void FillIncorrectDataForSignIn(string userName, string password)
        {
            authEmail.Click();
            authEmail.SendKeys(userName);
            authPassword.Click();
            authPassword.SendKeys(password);
            signInBTN.Click();
        }

        public void AssertErrorMessage()
        {
            String ExpectedMessage = "Authentication failed.";
            Assert.AreEqual(ExpectedMessage, errorMSG, "Different messages");
            Console.WriteLine("Oczekiwanym komunikatem jest: " + ExpectedMessage + ". W rzeczywistości otrzymaliśmy: " + errorMSG + ".");
        }
    }
}
