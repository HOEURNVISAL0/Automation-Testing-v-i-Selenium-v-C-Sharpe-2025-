using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium_UI_Web
{
    [TestFixture]
    public class Basefree
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://dogapi.dog/");
            Console.WriteLine("Set Up Sucessfull");
        }
        //[TearDown]
        //public void Teardown()
        //{
        //    driver?.Quit();
        //}
    }
}