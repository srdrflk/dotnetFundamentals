using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryToHandle
{
    public class HelloWorldManager
    {
        public string GetHelloMessage(string username)
        {
            return $"{DateTime.Now.ToString("T")} Hello, {username}!";
        }
    }
}
