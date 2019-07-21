using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace VideoLessons.TestSelenium.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver, bool headless)
        {
            IWebDriver webDriver = null;

            switch(browser)
            {
                case Browser.Chrome:
                ChromeOptions chromeOptions = new ChromeOptions();
                if(headless){
                    chromeOptions.AddArgument("--headless");
                }

                webDriver = new ChromeDriver(pathDriver, chromeOptions);
                break;
                

                case Browser.Firefox:
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                if(headless){
                    firefoxOptions.AddArgument("--headless--");
                }

                webDriver = new FirefoxDriver(pathDriver, firefoxOptions);
                break;


                
            }

            return webDriver;
            
        }

    }
}