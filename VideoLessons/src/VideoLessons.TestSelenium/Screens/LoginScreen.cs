using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using VideoLessons.TestSelenium.Utils;

namespace VideoLessons.TestSelenium.Screens{

    public class LoginScreen:BaseScreen
    {


    public LoginScreen(IConfiguration configuration, Browser browser): base(configuration, browser)
    {

    }
    public void SetText(string element, string value)
    {
         _webDriver.SetText(By.Id(element), value);
    }
    
    public void Submit()
    {
        _webDriver.Submit(By.Id("entrar"));
    }

    public string GetUserLogin(){
        WaitToHtml(TimeSpan.FromSeconds(10), By.ClassName("texto-branco"));

        string response = _webDriver.GetHtml(By.ClassName("texto-branco"));

        return response;
    }
     public string GetErrorMessage(){
        WaitToHtml(TimeSpan.FromSeconds(10), By.Id("mensagemDeErro"));

        string response = _webDriver.GetHtml(By.Id("mensagemDeErro")).Trim();

        return response;
    }
    }

