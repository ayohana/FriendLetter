using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{

  // This line below tells .NET that HomeController should inherit/extend functionality from ASP.NET Core's built-in Controller class that we import with our using/directive statement.
  public class HomeController : Controller
  {

    //Hello() method represents a route in our application. Because this method is a route, it will create a special path or pattern in our application. If we were to host this application, we'd have the following route because of the Hello() method in our controller: http://localhost:5000/home/hello (The path is the portion appended to the end of URL: /home/hello)
    public string Hello() { return "Hello friend!"; }

    public string Goodbye() { return "Goodbye friend."; }

  }
}