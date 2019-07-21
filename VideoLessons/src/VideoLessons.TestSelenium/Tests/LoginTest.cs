using VideoLessons.TestSelenium.Screens;
using VideoLessons.TestSelenium.Utils;
using Xunit;

namespace VideoLessons.TestSelenium.Tests{


    public class LoginTest:BaseTest
    {

        private readonly LoginScreen _loginScreen;
        public LoginTest()
        {
             _loginScreen = new LoginScreen(_configuration, Browser.Chrome);
        }

        [Theory]
        [InlineData("pri", "teamo")]

        public void DeveRealizarLoginComSucesso(string login, string password)
        {


        
         string response=null;
         
          
          try{
              
              _loginScreen.LoadScreen(_configuration.GetSection("Selenium:Urls:Login").Value);
              _loginScreen.SetText("login", login);
              _loginScreen.SetText("senha", password);
              _loginScreen.Submit();
              response = _loginScreen.GetUserLogin();

          } catch(System.Exception e)
          {
              throw e;
          }finally{
              _loginScreen.CloseScreen();
          }
          Assert.True(!string.IsNullOrEmpty(response));
          Assert.Equal(response, "PRISCILA ALVES ANTUNES BEM VINDO AO PORTAL DO ALUNO DA ESCOLA <strong>ECO APRENDER</strong>");




         }
        }
    }
