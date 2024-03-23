using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Framework
{
   public  class PageBase
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://hq.it-cores.com:8800/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
