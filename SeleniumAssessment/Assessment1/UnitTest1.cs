using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            string searc = "Dxc Technologies";
            driver = new ChromeDriver("C:\\Users\\Selenium Jars");
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.Name("q")).SendKeys(searc);

            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("gNO89b")).Click();
            string text  = driver.Title;
            Console.WriteLine(text);
            Console.WriteLine(driver.FindElement(By.Id("resultStats")).Text);
            driver.Close();
            Console.WriteLine("EXECUTED SUCCESSFULLY");

            if (text.Contains(searc))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }


        }
    }
}
