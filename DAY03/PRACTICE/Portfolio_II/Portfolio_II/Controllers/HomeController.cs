using Microsoft.AspNetCore.Mvc;
namespace Portfolio_II.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet]
    [Route("project")]
    public IActionResult Project()
    {
        return View("Project");
    }

    [HttpGet]
    [Route("contact")]
    public IActionResult Contact()
    {
        return View("Contact");
    }
}
