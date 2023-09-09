namespace Portafolio_Web_2023.Models
{
	//V#54 Listado de Proyectos

	/// <summary>
	/// DTO significa DataTransferObject y es una manera de llamar a clases que tienen
	/// como fin transportar datos de un modelo a otro.
	/// </summary>
	public class ProyectoViewModel
	{
		public string? Titulo { get; set; }
		public string? Descripcion { get; set; }
		public string? ImagenURL { get; set; }
		/// <summary>
		/// Para poder navegar hacia el proyecto a otra ubicación
		/// </summary>
		public string? Link { get; set; }
	}
}
