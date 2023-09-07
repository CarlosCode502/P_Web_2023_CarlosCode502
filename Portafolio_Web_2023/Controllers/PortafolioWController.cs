using Microsoft.AspNetCore.Mvc;
using Portafolio_Web_2023.Models;
using System.Diagnostics;

namespace Portafolio_Web_2023.Controllers
{
    public class PortafolioWController : Controller
    {
        private readonly ILogger<PortafolioWController> logger;

        public PortafolioWController(ILogger<PortafolioWController> logger) {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
