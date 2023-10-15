﻿using Microsoft.AspNetCore.Mvc;
using Portafolio_Web_2023.Models;
using Portafolio_Web_2023.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore;
using Portafolio_Web_2023.Models.CVs_VM_Resources;
//using Grpc.Core;

namespace Portafolio_Web_2023.Controllers
{
    public class PortafolioWController : Controller
    {
        //V#57 Inyección de dependencias 
        //Con la Inyección de dependencias
        //Delagmos la instanciación de las dependencias de nuestras clases a otras clases
        //Campo de la clase 

        //Realizamos la inyección del la inerfaz del repositorio

        #region Campos generados automáticamente
        private readonly ILogger<PortafolioWController> logger;
        private readonly IRepositorioProyecto repositorioProyecto;
        private readonly IServicioEmailSendGrid servicioEmailSendGrid;
        private readonly IRepositorioArchivos repositorioArchivos;
        #endregion

        //V#60 Entendiendo ILoger msjs de logs(Cuando se pasa ILogger a HomeController detectara los logs en la consola)
        //Ctrl+. y en Create and assign fiel 'logger' para crearlo como CAMPO y agregar automaticamente los valores
        //V#? Inyección de dependencias(Inyectando el servicio de SendGrid)
        public PortafolioWController(ILogger<PortafolioWController> logger, IRepositorioProyecto repositorioProyecto, IServicioEmailSendGrid servicioEmailSendGrid, IRepositorioArchivos repositorioArchivos)
        {
            //Generados automáticamente
            this.logger = logger;
            this.repositorioProyecto = repositorioProyecto;
            this.servicioEmailSendGrid = servicioEmailSendGrid;
            this.repositorioArchivos = repositorioArchivos;
        }

        public IActionResult Index()
        {
            //V#56 Principio de responsabilidad Única
            //Se crea una instancia para poder acceder a la clase y a sus métodos
            //Se comento debido a V#57 Inyección de dependencias 
            //RepositorioProyectos repositorioProyectos = new();

            //V#54 Listado de Proyectos
            //Mostraremos los 3 proyectos más recientes.
            var proyectos = repositorioProyecto.ObtenerListadoProyectos().Take(3).ToList();

            //Obtenemos los 3 proyectos más recientes y los mandamos al IEnumerable (como ya recibe un modelo con los mismos datos)
            //Mismo IEnumerable que debe pasarse a la vista para poder mostrar los datos.
            var modelo = new PortafolioIndexViewModel
            {
                //Asignamos los proyectos obtenidos al IEnumerable 
                Proyectos = proyectos
            };

            //mandamos el modelo a la vista para poder acceder y manejar los datos
            return View(modelo);
        }

        /*v#56 principio de responsabilidad única
		aqui estaba mi metodo obtener listado*/

        //V#62 Creando una Nueva Vista - Mostrando todos los proyectos.
        //Controlador para la nueva vista(pag) en donde se mostrarán todos mis proyectos.
        public IActionResult Proyectos()
        {
            //Pasamos todos los proyectos
            var proyectos = repositorioProyecto.ObtenerListadoProyectos();

            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Cv()
        {
            //var archivosDropDowList = repositorioArchivos.ListadoArchivos();

            //var modelo = new ArchivosSelectListViewModelcs
            //{
            //    //Casteamos para poder importar el método
            //    ArchviosListados = new List<SelectListItem>()
            //};

            ////var modelo = new ArchivosViewModel();
            ////modelo.archivosDropDowList = new List<SelectListItem>(); 

            ////ViewData["archivo"] = archivosDropDowList;

            //foreach (var archivo in archivosDropDowList)
            //{
            //    modelo.ArchviosListados.Add(new SelectListItem { Text = archivo.Name, Value = archivo.Id.ToString() });
            //}

            //var archivosList = repositorioArchivos.ListadoArchivos();
            //return View("cv", archivosList);

            //Asignamos una var para obtener el listado del repo
            //obtendra todos los elementos como una lista estatica
            var cvsData = new RepositorioArchivos().ListadoArchivos();
            
            //Inicializamos el modelo que contendra la lista y el elemento seleccionado 
            //para asi pasar los datos del repo al modelo list
            var modelo = new CVs_Portafolio_ViewModel();
            modelo.cvs_selectListItems = new List<SelectListItem>();

            //Ahora un bucle que ira recorriendo y mostrando las propiedades
            foreach (var cvs in cvsData)
            {
                //segun se vaya recorriendo se agregara un elemento al drop con valor y nombre
                modelo.cvs_selectListItems.Add(new SelectListItem { Text = cvs.Nombre, Value = cvs.Id.ToString() });
                //var ruta = cvs.Ruta;
            }

            return View("cv", modelo);
        }

        [HttpPost]
        public IActionResult Cv(CVs_Portafolio_ViewModel cVs_Portafolio_ViewModel)
        {
            //creamos una variable para obtener el valor del elemento seleccionado
            //CVsViewModel cVsViewModel = new CVsViewModel();
            //RepositorioArchivos repositorioArchivos = new RepositorioArchivos();    

            var cvseleccionado = cVs_Portafolio_ViewModel.CV_Seleccionado;
            int obInt = Convert.ToInt32(cvseleccionado);

            if (obInt >= 0)
            {
                if (obInt == 1)
                {
                    return RedirectToAction("ArchivoHtml");
                }
                else if (obInt == 2)
                {
                    return RedirectToAction("ArchivoCanva");
                }
            }

            //return View("cv",cVs_Portafolio_ViewModel);
            return RedirectToAction("cv");
        }

        ////V#9 Decarga de archivo von FileResult
        ////RETORNAR UN ARCHIVO DE NUESTRO SERVIDOR AL USUARIO(Descargar)
        public FileResult ArchivoHtml()
        {
            //CVsViewModel cVsViewModel = new CVsViewModel();

            //var ruta = cVsViewModel.Ruta;
            var ruta = "/Resources/Simple Cv-Carlos-Herrera.pdf";
            //var ruta = repositorioArchivos.ListadoArchivos();
            //ruta = Server.MapPath("./Resources/Intro Exel.pdf");
            return File(ruta, "application/pdf", "Cv-Simple-Carlos-Herrera.pdf");
        }

        ////V#9 Decarga de archivo von FileResult
        ////RETORNAR UN ARCHIVO DE NUESTRO SERVIDOR AL USUARIO(Descargar)
        public FileResult ArchivoCanva()
        {
            //CVsViewModel cVsViewModel = new CVsViewModel();

            //var ruta = cVsViewModel.Ruta;
            var ruta = "/Resources/Currículum Vitae Cv.pdf";

            return File(ruta, "application/pdf", "Cv-Carlos-Herrera Canva.pdf");
        }



        //public async Task<FileResult> GetFoto(int id)
        //{
        //    //byte[] fileBytes = 
        //    var ms = new MemoryStream(fileBytes!);
        //    return new FileStreamResult(ms, "application/pdf");
        //    // o tambien:
        //    //return File(fileBytes, "application/pdf", "nombre.pdf");
        //}


        //public IActionResult DamePdf(LDModel ld, string returnUrl)
        //{
        //    string contentType = System.Net.Mime.MediaTypeNames.Application.Pdf;
        //    return new FilePathResult(ld.fullPathfileName, contentType);
        //      //{ 
        //      //    FileDownloadName = ld.FileName,
        //      //};
        //}



        [HttpGet]
        //V#63 Creando un simple formulario
        //Solicitud HTTP Get solo mostrar datos
        public IActionResult Contacto()
        {
            return View();
        }

        //V#64 HTTP Post - Posteando el formulario
        //Accion que se va a ejecutar ante una solicitud HttpPost
        [HttpPost]
        //Especificamos que vamos a recibir los datos de un modelo
        //public IActionResult Contacto(ContactoViewModel contactoViewModel)
        //{
        //Lo cambiamos a un método Asyncrono
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            //Instrucción Try-Catch
            //Control o manejo de exepciones
            try
            {
                //return View();

                //V#65 Patrón Post-Redirección-Get
                //Al mento de llenar los datos y hacer submit por error o fallo se pueden volver a reenviar los datos 
                //lo que no es correcto, para evitar eso es necesario redirigir al usuario al momento de completar una
                //accion como la de llenar un formulario

                //Se va a redirigir al usuario a un nuevo formulario de agradecimiento(vista)
                //V#66 ENVIANDO EMAILS DESDE LA APP()
                if (ModelState.IsValid)
                {
                    await servicioEmailSendGrid.Enviar(contactoViewModel);
                    return RedirectToAction(nameof(Gracias));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de envio, los detalles son los siguientes:\n{ex.Message}");
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
