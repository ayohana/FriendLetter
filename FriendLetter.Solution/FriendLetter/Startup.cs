using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
// These built-in .NET namespaces can help us construct HTTP requests, configure our project, and ensure necessary built-in functionality is present in the correct areas.


namespace FriendLetter
{
  public class Startup
  {

    // The constructor below will create an iteration of the Startup class that contains specific settings and variables to run our project successfully. It's required for configuring a basic ASP.NET Core MVC project.
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    // This line below is the process of adding custom configurations to our project.
    public IConfigurationRoot Configuration { get; }

    // This line below is a required built-in method used to set up an application's server. We can use it to configure other framework services.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc(); // Adds the MVC service to the project (ensuring our dependencies are available in the necessary areas)
    }

    // Configure() below is responsible for telling our app how to handle requests to the server. The code inside Configure() states which area of our application should load by default when it launches.
    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage(); // provides a more detailed error message when a Razor page fails to load due to a server error.
      app.UseMvc(routes => // tells our app to use the MVC framework to respond to HTTP requests
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) => // to test if our Configure() method is working properly
      {
        await context.Response.WriteAsync("Hello World!"); // tells our app to print "Hello World" if a proper MVC route CANNOT be found. Since we haven't created any routes yet, our application displays this on localhost:5000.
      });
    }

  }
}