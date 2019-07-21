using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using VideoLessons.TestSelenium.Utils;

namespace VideoLessons.TestSelenium.Screens{

    public class HomeScreen:BaseScreen
    {


    public HomeScreen(IConfiguration configuration, Browser browser): base(configuration, browser)
    {

    }

    public string GetServices(){
        WaitToHtml(TimeSpan.FromSeconds(10), By.Id("servicos"));

        string response = _webDriver.GetHtml(By.Id("servicos"));

        return response;
    }
        
    
}
}