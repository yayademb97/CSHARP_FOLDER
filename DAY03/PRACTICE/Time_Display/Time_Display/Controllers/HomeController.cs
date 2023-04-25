using Microsoft.AspNetCore.Mvc;
namespace Time_Display.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        ViewBag.CurrentTime = DateTime.Now;
        return View("Index");
    }
}