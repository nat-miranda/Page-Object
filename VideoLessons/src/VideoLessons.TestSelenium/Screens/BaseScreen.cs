using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using VideoLessons.TestSelenium.Utils;

namespace VideoLessons.TestSelenium.Screens
{
    public class BaseScreen
    {
        protected readonly IConfiguration _configuration;
        protected readonly Browser _browser;

        protected IWebDriver _webDriver;

        public BaseScreen(IConfiguration configuration, Browser browser)
        {
            _configuration = configuration;
            _browser = browser;

            _webDriver = WebDriverFactory.CreateWebDriver(browser, configuration.GetSection("Selenium:Drivers:Path").Value, false);

        }
    
        public void LoadScreen(string url)
        {

         _webDriver.LoadPage(TimeSpan.FromSeconds(15), url);
         _webDriver.Manage().Window.Maximize();
        }

        public void CloseScreen()
        {
            _webDriver.Quit();
            _webDriver = null;
        }

        public void WaitToHtml(TimeSpan secondsToWait, By by)
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, secondsToWait);
            wait.Until(x => !string.IsNullOrEmpty(x.FindElement(by).GetAttribute("innerHTML")));

        }

        public void WaitByValue( TimeSpan secondsToWait, By by)
        {
             WebDriverWait wait = new WebDriverWait(_webDriver, secondsToWait);
            wait.Until(x => !string.IsNullOrEmpty(x.FindElement(by).GetAttribute("value")));
        }

    }

       
    }
            
        
        
