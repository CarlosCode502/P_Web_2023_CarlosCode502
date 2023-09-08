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
			//V#56 Principio de responsabilidad Única
			//Se crea una instancia para poder acceder a la clase y a sus métodos
			//Se comento debido a V#57 Inyección de dependencias 
			//RepositorioProyectos repositorioProyectos = new();

			//V#54 Listado de Proyectos
			//Mostraremos los 3 proyectos más recientes.
            

			return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
