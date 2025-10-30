using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"..\..\..\..\chromedriver.exe");

            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.spbstu.ru/abit/bachelor/");
        }

        [Test]
        public void Test_LogoIsDisplayed()
        {
            wait.Until(d => driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/div/div/a[1]/img")).Displayed);
            var logo = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/div/div/a[1]/img"));
            ClassicAssert.IsTrue(logo.Displayed);
        }

        [Test]
        public void Test_GoToUrl()
        {
            driver.Navigate().GoToUrl("https://www.spbstu.ru/");
            string expected = "Санкт-Петербургский политехнический университет Петра Великого - Высшее образование в России";
            string actual = driver.Title;
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Login()
        {
            wait.Until(d => driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/div/div/a[5]")).Displayed);
            var loginBtn = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div/div/div/a[5]"));
            loginBtn.Click();

            //Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            wait.Until(d => driver.FindElement(By.XPath("//*[@id=\":r0:\"]")).Displayed);
            var usernameField = driver.FindElement(By.XPath("//*[@id=\":r0:\"]"));

            wait.Until(d => driver.FindElement(By.XPath("//*[@id=\":r1:\"]")).Displayed);
            var passwordField = driver.FindElement(By.XPath("//*[@id=\":r1:\"]"));

            wait.Until(d => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div/div/form/div[2]/button")).Displayed);
            var submit = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div/div/form/div[2]/button"));

            usernameField.SendKeys("test");
            passwordField.SendKeys("test");
            submit.Click();

            wait.Until(d => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div/div/form/div[1]/div[2]/div[1]/div[2]")).Displayed);
            var error = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div/div/form/div[1]/div[2]/div[1]/div[2]"));

            string expected = "Значением поля должен быть валидный email";
            string actual = error.Text;
            ClassicAssert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
