using Microsoft.Extensions.Configuration;
using System.IO;

namespace VideoLessons.TestSelenium.Tests
 {
     public class BaseTest{

        protected IConfiguration _configuration; 

        public BaseTest()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }
        
            
        
     }
 }