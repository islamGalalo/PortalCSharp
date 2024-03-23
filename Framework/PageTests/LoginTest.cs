using Framework.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace Framework.PageTests
{
  public  class LoginTest 
    {
  
        WebDriver driver;
        Loginpage loginpage;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://hq.it-cores.com:8800/");
        }

    
        [Test]
        public void LoginToHomePage() { 
        loginpage = new Loginpage(driver);
         loginpage.Username();
            loginpage.Password();
            loginpage.Submit();
        
        
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
