using Microsoft.AspNetCore.Mvc;
namespace Portfolio_I.Controllers; // Include the controller in the project 
public class HelloController : Controller
{
    [HttpGet("")]
    public string Index()
    {
        return "This is my index page";
    }


    [HttpGet("/project")]
    public string Project()
    {
        return "This is my project";
    }


    [HttpGet("/project/contact")]
    public string Contact()
    {
        return "This is my contact";
    }
}