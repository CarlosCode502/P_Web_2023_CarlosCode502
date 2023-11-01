using Microsoft.AspNetCore.Mvc;
using Portafolio_Web_2023.Models;
using Portafolio_Web_2023.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portafolio_Web_2023.Models.CVs_VM_Resources;

namespace Portafolio_Web_2023.Controllers
{
    public class PortafolioWController : Controller
    {
        #region Campos generados automáticamente
        private readonly ILogger<PortafolioWController> logger;
        private readonly IRepositorioProyecto repositorioProyecto;
        private readonly IServicioEmailSendGrid servicioEmailSendGrid;
        //private readonly IRepositorioArchivos repositorioArchivos;
        #endregion

        public PortafolioWController(ILogger<PortafolioWController> logger, IRepositorioProyecto repositorioProyecto, IServicioEmailSendGrid servicioEmailSendGrid/*, IRepositorioArchivos repositorioArchivos*/)
        {
            //Generados automáticamente
            this.logger = logger;
            this.repositorioProyecto = repositorioProyecto;
            this.servicioEmailSendGrid = servicioEmailSendGrid;
            //this.repositorioArchivos = repositorioArchivos;
        }

        public IActionResult Index()
        {            
            var proyectos = repositorioProyecto.ObtenerListadoProyectos().Take(3).ToList();

            var modelo = new PortafolioIndexViewModel
            {
                Proyectos = proyectos
            };
           
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            //Pasamos todos los proyectos
            var proyectos = repositorioProyecto.ObtenerListadoProyectos();

            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Cv()
        {                       
            var cvsData = new RepositorioArchivos().ListadoArchivos();

            var modelo = new CVs_Portafolio_ViewModel
            {
                cvs_selectListItems = new List<SelectListItem>()
            };

            foreach (var cvs in cvsData)
            {
                modelo.cvs_selectListItems.Add(new SelectListItem { Text = cvs.Nombre, Value = cvs.Id.ToString() });
            }

            return View("cv", modelo);
        }

        [HttpPost]
        public IActionResult Cv(CVs_Portafolio_ViewModel cVs_Portafolio_ViewModel)
        {

            //switch expresión
            return cVs_Portafolio_ViewModel.CV_Seleccionado.ToString() switch
            {
                "1" => RedirectToAction("ArchivoHtml"),
                "2" => RedirectToAction("ArchivoCanvaConFoto"),
                _ => RedirectToAction("cv"),
            };

            ////Anterior
            //switch (cVs_Portafolio_ViewModel.CV_Seleccionado.ToString())
            //{
            //    case "1":
            //        return RedirectToAction("ArchivoHtml");

            //    case "2":
            //        return RedirectToAction("ArchivoCanvaConFoto");

            //    default:
            //        return RedirectToAction("cv");
            //        //    break;
            //}
        }

        public FileResult ArchivoHtml()
        {           
            var ruta = "/Resources/Simple Cv-Carlos-Herrera.pdf";
            return File(ruta, "application/pdf", "Cv-Carlos-Herrera-Simple.pdf");
        }

        public FileResult ArchivoCanvaConFoto()
        {           
            var ruta = "/Resources/Cv-Carlos-Herrera Canva.pdf";
            return File(ruta, "application/pdf", "Cv-Carlos-Herrera-diseño-Canva.pdf");
        }        

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {          
            try
            {               
                if (ModelState.IsValid)
                {
                    await servicioEmailSendGrid.Enviar(contactoViewModel);
                    return RedirectToAction("Gracias");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de envio, los detalles son los siguientes:\n{ex.Message}");
                //Thread.Sleep(500);
                ViewBag.msjError = "¡No se ha podido enviar el formulario, por favor intente por otro medio!";
            }
            return View(contactoViewModel);
        }

        [HttpGet]
        public IActionResult Gracias()
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
