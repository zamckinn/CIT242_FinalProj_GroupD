using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CIT242FinalProj.mvc.Models;
using CIT242FinalProj.mvc.Data;
namespace CIT242FinalProj.mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext db;

    public HomeController(ILogger<HomeController> logger,ApplicationDbContext injectedContext)
    {
        _logger = logger;
         db = injectedContext;
    }

    public IActionResult Index()
    {
        HomeTaskModel model = new
        (
            Tasks: db.Tasks.ToList()
        );

        return View(model);
    }

    [HttpPost]
    public IActionResult Input(HomeTaskModel model)
    {

        //db.Tasks.Add(model);
        //db.SaveChanges();
        
        return RedirectToAction("Index");
    }

    public IActionResult Scoreboard() 
        {
          ScoreboardModel model = new
            ( 
            Scoreboard: db.Scoreboard.ToList()
            );
            return View(model);
        }

    public IActionResult Create() 
    {
        return View();
    }

    public IActionResult Settings() 
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
