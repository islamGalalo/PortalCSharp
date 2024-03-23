using OpenQA.Selenium;  
namespace Framework.PageObjects
{
    public class Loginpage 
    {
        WebDriver driver;
        By username = By.XPath("//input[@type='text']");
        By password = By.XPath("//input[@type='password']");
        By submit = By.XPath("//button[@type='submit']");

        public Loginpage(WebDriver driver)
        {
            this.driver = driver;
        }

        public void Username()
        {
            driver.FindElement(username).SendKeys("islam");

        }
        public void Password()
        {
            driver.FindElement(password).SendKeys("Password");
        }
        public void Submit()
        {
            driver.FindElement(submit).Click();
        }


    }
}