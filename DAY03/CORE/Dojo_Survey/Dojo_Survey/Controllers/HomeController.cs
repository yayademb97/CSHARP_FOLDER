using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
    [HttpGet("second/{name}")]
    public string Second(string name)
    {
        return $"Hi {name}😄";
    }
    [HttpGet("third/{location}")]
    public string Third(string location)
    {
        return $"This is your Location: {location}";
    }
    [HttpGet("fourth/{location}")]
    public string fourth(string language)
    {
        return $"And your Favorite Language is: {language}";
    }
    [HttpGet("fifth/{comment}")]
    public string Fifth(string comment)
    {
        return $"And your Comment is: {comment}";
    }


    [HttpGet("display")]
    public ViewResult Display()
    {
        ViewBag.Name = "Alex";
        ViewBag.Location = "Las Vegas";
        ViewBag.Language = "Python";
        ViewBag.Comment = "Las Vegas";
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string Name, string Location, string Language, string Comment)
    {
        System.Console.WriteLine($"Name : {Name}\n Location: {Location}\n Language: {Language}\n Comment: {Comment} ");
        if (Name == "" || Location == "" || Language == "" || Comment == "")
        {
            ViewBag.Error = "Wrong Information";
            return RedirectToAction("Index");
        }
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;

        return View("Display");
    }

}