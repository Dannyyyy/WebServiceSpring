using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOTRAP6
{
        public interface IHelloWorldService
        {
            string GreetUser(string userName);
        }
        [WebService(Namespace = "http://myCompany/services")]
        public class HelloWorldServiceImpl : IHelloWorldService
        {
            public string Greeting { set; get; }
        [WebMethod]
        public string GreetUser(string userName)
            {
                return Greeting + userName;
            }
        }
}