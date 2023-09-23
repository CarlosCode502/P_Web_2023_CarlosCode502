﻿using Microsoft.AspNetCore.Mvc;
using Portafolio_Web_2023.Models;
using Portafolio_Web_2023.Services;
using System.Diagnostics;

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
        #endregion

        //V#60 Entendiendo ILoger msjs de logs(Cuando se pasa ILogger a HomeController detectara los logs en la consola)
        //Ctrl+. y en Create and assign fiel 'logger' para crearlo como CAMPO y agregar automaticamente los valores
        //V#? Inyección de dependencias(Inyectando el servicio de SendGrid)
        public PortafolioWController(ILogger<PortafolioWController> logger, IRepositorioProyecto repositorioProyecto, IServicioEmailSendGrid servicioEmailSendGrid) {
			//Generados automáticamente
			this.logger = logger;
			this.repositorioProyecto = repositorioProyecto;
            this.servicioEmailSendGrid = servicioEmailSendGrid;
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

		public IActionResult Cv()
		{
			return View("cv");	
		}

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
			//return View();

			//V#65 Patrón Post-Redirección-Get
			//Al mento de llenar los datos y hacer submit por error o fallo se pueden volver a reenviar los datos 
			//lo que no es correcto, para evitar eso es necesario redirigir al usuario al momento de completar una
			//accion como la de llenar un formulario

			//Se va a redirigir al usuario a un nuevo formulario de agradecimiento(vista)
			//V#66 ENVIANDO EMAILS DESDE LA APP()

			await servicioEmailSendGrid.Enviar(contactoViewModel);
			return RedirectToAction("Gracias");
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
