
using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Assessment1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new FirefoxDriver("C:\\Users\\Selenium Jars");

            driver.Url = "http://www.youcandealwithit.com/";
            driver.Manage().Window.Maximize();
            IWebElement radio = driver.FindElement(By.XPath("//a[text()='Borrowers']"));
            Actions act = new Actions(driver);
            act.MoveToElement(radio).Build().Perform();
            driver.FindElement(By.XPath("//*[text()='Calculators & Resources']")).Click();
            string a = driver.FindElement(By.XPath("//*[text()='Calculators & Resources']")).Text;
            if (driver.FindElement(By.XPath("//*[text()='Calculators & Resources']")).Text.Contains(driver.Title))
            {
                Console.WriteLine("Calculators & Resources Pass");
            }
            else
            {
                Console.WriteLine("Calculators & Resources fails");
            }
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Calculators")).Click();
            string b = driver.FindElement(By.LinkText("Calculators")).Text;
            if (b.Contains(driver.Title))
            {
                Console.WriteLine(" Calculators Pass");
            }
            else
            {
                Console.WriteLine(" Calculators fails");
            }
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Budget Calculator")).Click();
            string c = driver.FindElement(By.LinkText("Budget Calculator")).Text;
            if (c.Contains(driver.Title))
            {
                Console.WriteLine(" Budget Calculator Pass");
            }
            else
            {
                Console.WriteLine("Budget Calculator fails");
            }
            Thread.Sleep(2000);
            driver.FindElement(By.Id("food")).SendKeys("5000");
            Thread.Sleep(1500);
            driver.FindElement(By.Id("clothing")).SendKeys("12000");
            Thread.Sleep(1500);
            driver.FindElement(By.Id("shelter")).SendKeys("11000");
            Thread.Sleep(1500);
            driver.FindElement(By.Id("monthlyPay")).SendKeys("50000");
            Thread.Sleep(1500);
            driver.FindElement(By.Id("monthlyOther")).SendKeys("8000");
            Thread.Sleep(10000);

            IWebElement exp = driver.FindElement(By.Id("totalMonthlyExpenses"));
            string expenses = exp.GetAttribute("value");

            Console.WriteLine(expenses);

            IWebElement mpay = driver.FindElement(By.Id("monthlyPay"));
            string expense = mpay.GetAttribute("value");
            if (Double.Parse(expenses) <= Double.Parse(expense))
            {
                Console.WriteLine("YOU ARE WARREN WAFFET");
            }
            else
            {
                Console.WriteLine("You are an VM");
            }



           // driver.Close();
        }
    }
}
