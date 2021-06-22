using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestTestTest;
using TestTestTest.PageObjects;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace CSharpPractice
{
    class CSharpPractice
    {
        public static IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new System.Drawing.Point(1, 1);
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
        }

        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            string expectedURL = "http://automationpractice.com/index.php";
            Assert.AreEqual(expectedURL, driver.Url, "Different URLs");
            Console.WriteLine("Oczekiwanym adresem jest: " + expectedURL + ". W rzeczywistoœci otrzymaliœmy: " + driver.Url + ".");
        }

        [TearDown]
        public void CloseBrowser()
        {
            // driver.Close();
            // driver.Quit();
        }

    }
}