using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://login.yahoo.com/?.src=finance&.intl=us&.done=https%3A%2F%2Ffinance.yahoo.com%2Fportfolios%253Fbypass%3Dtrue%3Fbypass%3Dtrue&add=1");
            chromeDriver.FindElementByXPath("//*[@id="login - username"]").Click();
            chromeDriver.Keyboard.SendKeys("kyle7150@yahoo.com");
            chromeDriver.Keyboard.SendKeys(Keys.Enter);
            //var content = new testentities();
            //var post = new table_1()C:\Users\Owner-14\source\repos\ConsoleApp4\ConsoleApp4\Program.cs
            //{
            //    body = "body",
            //    datpulished = datetime.now,
            //    postid = 2,
            //    title = "title"

            //};
            //content.table_1.add(post);
            //content.savechanges();
        }
    }
}
