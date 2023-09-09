using Portafolio_Web_2023.Models;

namespace Portafolio_Web_2023.Services
{
	//V#58 Inyección de dependencias con Interfaces
	//Una interfaz es como un contrato que nos obliga a implementar ciertos metodos de una clase.
	//Una de las ventajas de utilizar inyección de dependencias es poder agregar flexibilidad en las relaciones de nuestras clases
	public interface IRepositorioProyecto
	{
		//Se creó automáticamente luego de Pull Up al método que se encuentra en otra clase
		//Donde estan alojados todos los proyectos
		List<ProyectoViewModel> ObtenerListadoProyectos();
	}
}
