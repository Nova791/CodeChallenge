using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace QACodeChallenge{
    class Program{
        static void Main(string[] args){
            IWebDriver driver = new FirefoxDriver();//Sets the driver browser to Firefox for testing

            try{
                driver.Navigate().GoToUrl("https://www.google.com/");//Attempt to navigate to google
            }catch (OpenQA.Selenium.WebDriverException e){
                Console.Write(e.ToString());//Return any errors/exceptions that could be returned if the page is unavailable or other issues occur
            }
            
            driver.Quit();//Closes the driver, and Firefox
        }
    }
}