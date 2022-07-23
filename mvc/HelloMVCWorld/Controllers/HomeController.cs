using HelloMVCWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new Movie( "The Godfather", new DateTime(1972, 3, 24) ));
    }
}
