using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Equinox.Models;

namespace Equinox.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return Content("Main Area, Home Controller, Contact Action");
    }

    public IActionResult Terms()
    {
        return Content("Main Area, Home Controller, Terms & Conditions Action");
    }

    public IActionResult CookiePolicy()
    {
        return Content("Main Area, Home Controller, Cookie Policy Action");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
