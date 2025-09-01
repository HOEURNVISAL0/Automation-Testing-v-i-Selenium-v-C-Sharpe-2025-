using OpenQA.Selenium;


namespace webNUnit.Pages 
{

    public class Config
    {
        private readonly IWebDriver driver;
        
        public Config (IWebDriver driver)
        {
            this.driver = driver;
        }

        public void demoLink (string name) {
            var demoLink = driver.FindElement(By.LinkText($"{name}"));
            demoLink.Click();
            Thread.Sleep(1000);
        }

        public void breedInput(string Keyx) {
            Assert.AreEqual("https://dogapi.dog/demo", driver.Url);
            var breedInput = driver.FindElement(By.Id("breedId"));
            breedInput.SendKeys($"{Keyx}");
            Thread.Sleep(1000);
            //f72528b5-a5d7-4a17-b709-aba2db722307
        }

        public void getBreedButton(string PATHx) {
            var getBreedButton = driver.FindElement(By.XPath($"{PATHx}"));
            getBreedButton.Click();
            Thread.Sleep(1000);
            ///html/body/main/div/div[2]/button
        }
        public void getclickURL(string PATHx)
        {
            var getclickURL = driver.FindElement(By.XPath($"{PATHx}"));
            getclickURL.Click();
            //Thread.Sleep(1000);
            ///html/body/main/div/div[2]/div/a
        }

    }
}