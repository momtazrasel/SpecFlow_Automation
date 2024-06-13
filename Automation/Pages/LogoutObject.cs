using NUnit.Framework;
using OpenQA.Selenium;


namespace Automation_Part_Two.Pages
{
    public class LogoutObject
    {
        private IWebDriver driver;
        public LogoutObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
        By userNameField = By.XPath("//input[@name='LoginCredential']");
        By passwordField = By.XPath("(//input[@name='Password'])[1]");
        By allCookies = By.XPath("(//button[@id='onetrust-accept-btn-handler'])[1]");
        By loginButton = By.XPath("(//button[normalize-space()='log in'])[1]");
        By crossIcon = By.XPath("(//span[@class='cross icon icon-cross'])[1]");
        By tagline = By.XPath("(//div[@class='tagline'])[1]");
        By logo = By.XPath("(//div[@class='logo iac'])[1]");
        By logOutButton = By.XPath("(//a[normalize-space()='logout'])[1]");


        public void taglineText()
        {

            //Header Assertion
            string actualText = driver.FindElement(tagline).Text;
            Assert.AreEqual("Britain's biggest bingo site", actualText, $"Expected tagline to be 'Britain's biggest bingo site' but was '{actualText}'");

            //Logo assertion
            bool isDisplayed = driver.FindElement(logo).Displayed;
            Assert.IsTrue(isDisplayed, "The tagline element is not displayed.");

        }

        public void getUsername()
        {


            Thread.Sleep(5000);
            driver.FindElement(allCookies).Click();
            Thread.Sleep(2000);
            driver.FindElement(userNameField).Click();
            Thread.Sleep(1000);
            driver.FindElement(userNameField).SendKeys("Techtest1");
        }

        public void getUserPassword()
        {
            Thread.Sleep(1000);
            driver.FindElement(passwordField).Click();
            Thread.Sleep(1000);
            driver.FindElement(passwordField).SendKeys("TechTest1!");
            Thread.Sleep(1000);
        }

        public void getLoginButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(loginButton).Click();
            Thread.Sleep(3000);
            driver.FindElement(crossIcon).Click();
            Thread.Sleep(1000);
        }
        public void getLogOutButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(logOutButton).Click();

        }


    }
}
