using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetMeritoWebApp.Models;

namespace DotNetMeritoWebApp.Controllers;

public class CarController : Controller
{
  private readonly ILogger<CarController> _logger;

  public CarController(ILogger<CarController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    var carsList = new List<CarViewModel>();
    carsList.Add(new CarViewModel { Name = "GLA", Color = "white", Brand = "Mercedes" });
    carsList.Add(new CarViewModel { Name = "X5", Color = "red", Brand = "BMW" });
    carsList.Add(new CarViewModel { Name = "Roadster", Color = "black", Brand = "Tesla" });

    return View(carsList);
  }

}
