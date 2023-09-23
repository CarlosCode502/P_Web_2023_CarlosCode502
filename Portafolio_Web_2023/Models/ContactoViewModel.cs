using System.ComponentModel.DataAnnotations;

namespace Portafolio_Web_2023.Models
{
    //V#? CREANDO EL MODELO DE CONTACTO
    public class ContactoViewModel
    {
        //En este caso no se establece un ID dado que únicamente se va a mostrar
        //y no se va a realizar alguna consulta.
        //public int Id { get; set; } 

        //V#35 Delimintando campos de texto con StringLength
        //Sirve para especificar que un String deba tener un longitud exacta o un rango de longitud
        //Y para especificar un rango Min(x) y Max(y) [StringLength(6, MinimumLength = 5)] 
        //Se personaliza el msj de error [ ErrMsj="El campo {0} debe tener
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} debe tener una longitud miníma de {2} y máxima de {1}")]
        public string? Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        //V#45 Passwords y TextArea, Scaffolfing DataType(Permite especificar el tipo de dato del textbox)
        //Es muy útil cuando se desea personalizar el tipo de dato que se desea guardar en este 
        //En este caso el campo de esta propiedad pasa de ser un txt normal a un txt multilinea
        [Required]
        [DataType(DataType.MultilineText)]
        public string? Mensaje { get; set; }
    }
}
