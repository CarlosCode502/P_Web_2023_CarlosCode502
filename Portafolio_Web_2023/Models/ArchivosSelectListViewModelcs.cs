using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portafolio_Web_2023.Models
{
    //V#54 Listado de Proyectos

    /// <summary>
    /// Esta clase va a servir para encapsular el modelo del Proyecto.
    /// Para luego a través del modelo acceder a los datos en la vista
    /// </summary>
    public class ArchivosSelectListViewModelcs
    {
        public string ArchivoSeleccionado { get; set; }

        /// <summary>
		/// Esta propiedad va a recibir lo relacionado al modelo ProyectoViewModel
		/// </summary>
        //Mostrar las propiedades
        //public List<SelectListItem> ArchviosListados { get; set; }
        public IEnumerable<ArchivosViewModel> archivosViewModels { get; set; }
    }
}
