using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portafolio_Web_2023.Models
{
    public class ArchivosSelectListViewModelcs
    {
        public string ArchivoSeleccionado { get; set; }

        //Mostrar las propiedades
        public IEnumerable<SelectListItem> ArchviosListados { get; set; }
    }
}
