using Microsoft.AspNetCore.Mvc.Rendering;

namespace Portafolio_Web_2023.Models.CVs_VM_Resources
{
    public class CVs_Portafolio_ViewModel
    {
        //Esta propiedad contendra el valor del elemento seleccionado
        public string CV_Seleccionado { get; set; }

        //Propiedad de visualización
        //contendra el id y el nombre y posiblemente ruta
        public List<SelectListItem> cvs_selectListItems { get; set; }
    }
}
