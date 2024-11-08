// See https://aka.ms/new-console-template for more information
using ClassLibraryToHandle;
using System.Xml.Linq;

HelloWorldManager helloWorldManager = new HelloWorldManager();

Console.Write("Please write your name : ");

string userName = Console.ReadLine();

while (string.IsNullOrEmpty(userName))
{
    Console.Write("Please write your name : ");

    userName = Console.ReadLine();
}

if (!string.IsNullOrEmpty(userName))
{
    Console.WriteLine("Hello, " + userName);

    var handledMessage = helloWorldManager.GetHelloMessage(userName);

    Console.WriteLine(handledMessage);
}
