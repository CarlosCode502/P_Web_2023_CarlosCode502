using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portafolio_Web_2023.Models
{
    public class ContactoViewModel
    {

        [Required(ErrorMessage = "* El campo {0} es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener una longitud miníma de {2} y máxima de {1} caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "* El campo {0} es obligatorio.")]

        [EmailAddress(ErrorMessage = "Ingrese una dirección de correo válida.")]
        [DisplayName("Correo")]
        public string Email { get; set; }

        [Compare("Email", ErrorMessage = "Ambos correos no coinciden.")]
        [DisplayName("Confirmar correo")]
        public string ConfirmarEmail { get; set; }

        [Required(ErrorMessage = "* El campo {0} es obligatorio.")]
        [DataType(DataType.MultilineText)]
        public string Mensaje { get; set; }
    }
}
