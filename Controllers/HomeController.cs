using Microsoft.AspNetCore.Mvc;

namespace AzureApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Ok(new { Message = "Hello World!" });
    }
}