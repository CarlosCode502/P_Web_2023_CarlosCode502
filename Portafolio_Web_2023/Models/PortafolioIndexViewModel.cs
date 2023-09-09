namespace Portafolio_Web_2023.Models
{
	//V#54 Listado de Proyectos

	/// <summary>
	/// Esta clase va a servir para encapsular el modelo del Proyecto.
	/// Para luego a través del modelo acceder a los datos en la vista
	/// </summary>
	public class PortafolioIndexViewModel
    {
		/// <summary>
		/// Esta propiedad va a recibir lo relacionado al modelo ProyectoViewModel
		/// </summary>
		public IEnumerable<ProyectoViewModel>? Proyectos { get; set; }

		////V#59 Servicios(Transient, Scoped, Singelton)
		//public EjemploGUIDViewModel? EjemploGUID_1 { get; set; }
		//public EjemploGUIDViewModel? EjemploGUID_2 { get; set; }
	}
}
