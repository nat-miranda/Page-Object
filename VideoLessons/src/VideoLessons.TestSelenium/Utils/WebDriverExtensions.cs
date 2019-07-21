using OpenQA.Selenium;
using System;

namespace VideoLessons.TestSelenium.Utils{

public static class WebDriverExtensions
{

public static void LoadPage(this IWebDriver webDriver, TimeSpan timeToWait , string url)
{
  webDriver.Manage().Timeouts().PageLoad = timeToWait;
  webDriver.Navigate().GoToUrl(url);
}

public static string GetHtml(this IWebDriver webDriver, By by)
{
    IWebElement webElement = webDriver.FindElement(by);
    return webElement.GetAttribute("innerHTML");
}


public static void SetText(this IWebDriver webDriver, By by, string value)
{
IWebElement webElement = webDriver.FindElement(by);
webElement.SendKeys(value);
}

public static void Submit(this IWebDriver webDriver, By by)
{
    IWebElement webElement = webDriver.FindElement(by);
    webElement.Submit();
}
}
}


