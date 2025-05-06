using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AI_Conversor.Models;
using AI_Conversor.ViewModels;

namespace AI_Conversor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration; 

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        string apiUrl = _configuration.GetValue<string>("FastApiBaseUrl") ?? "http://127.0.0.1:5003";

        var viewModel = new HomeViewModel
        {
            FastApiBaseUrl = apiUrl.TrimEnd('/') 
        };
        return View(viewModel);
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