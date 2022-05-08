using AzureApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureApp.Controllers;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet]
    [ProducesResponseType(typeof(OkResponse), 200)]
    public IActionResult Index()
    {
        return Ok(new { Message = "Hello World!" });
    }
}