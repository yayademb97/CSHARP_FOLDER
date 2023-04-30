using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey.Models;

namespace Dojo_Survey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpPost("survey")]
    public IActionResult Submission(Survey newSurvey)
    {
        Console.WriteLine($"Name : {yourSurvey.YourName}\nDojo Location: {yourSurvey.DojoLocation}\nFavourite Language: {yourSurvey.FavLanguage}\nComment: {yourSurvey.Comment}");
        if(ModelState.IsValid)
        {
            AllSurvey.Add(newSurvey);
            return RedirectToAction("Result", AllSurvey);
        }
        return View("Index");
    }
    [HttpGet("results")]
    public IActionResult Results()
    {
        return View("Result");
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
