using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{

  // This line below tells .NET that HomeController should inherit/extend functionality from ASP.NET Core's built-in Controller class that we import with our using/directive statement.
  public class HomeController : Controller
  {

    // The route decorater below provides additional info to a route we define. It overrides the default URL path so instead of needing to visit /home/hello, we can just type in /hello.
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    //Hello() method represents a route in our application. Because this method is a route, it will create a special path or pattern in our application. If we were to host this application, we'd have the following route because of the Hello() method in our controller: http://localhost:5000/home/hello (The path is the portion appended to the end of URL: /home/hello)

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")] // A root path and it's the homepage for our site
    public ActionResult Letter() { return View(); }
    // ActionResult is a built-in MVC class that handles rendering Views.
    // View() is a built-in method from Microsoft.AspNetCore.Mvc namespace. It locate views by name:
      // because views should always reside in a Views directory, View() first locates the Views directory in the production project.
      // then View() looks for a subdirectory with a name that matches the controller name, i.e. Home (in this case, our Letter() route is in a HomeController so it looks for the subdirectory Home.)
      // once in the subdirectory, View() then looks for a file that corresponds with the controller's route name (not the route decorator), i.e. Letter (it looks for Letter() -- Letter.cshtml)
    // NAMING CONVENTION IS VERY IMPORTANT HERE!
    // NOTE: VIEW() DOES NOT CARE ABOUT THE ROUTE DECORATOR!

  }
}