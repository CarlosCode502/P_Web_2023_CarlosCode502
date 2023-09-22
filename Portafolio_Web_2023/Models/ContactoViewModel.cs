namespace Portafolio_Web_2023.Models
{
    //V#? CREANDO EL MODELO DE CONTACTO
    public class ContactoViewModel
    {
        //En este caso no se establece un ID dado que únicamente se va a mostrar
        //y no se va a realizar alguna consulta.
        //public int Id { get; set; } 

        /// <summary>
        /// Contendrá el nombre
        /// </summary>
        public string? Name { get; set; }    
        /// <summary>
        /// Contendrá el correo
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// El mensaje o descripción
        /// </summary>
        public string? Message { get; set; }
    }
}
