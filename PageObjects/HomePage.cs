using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestTestTest.PageObjects
{
    class HomePage
    {
        String homePageURL = "http://automationpractice.com/index.php";

        private IWebDriver driver;
        private WebDriverWait wait;
        Int32 timeout = 10000;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "login")]
        [CacheLookup]
        private IWebElement signInBtn;

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(homePageURL);
        }

        public void ClickSignInButton()
        {
            signInBtn.Click();
        }
    }
}
