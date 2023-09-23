//v#66 ENVIANDO EMAILS DESDE LA APP 02
//PRIMERO SE DEBE INSTALAR EL NUGET DE SENDGRID
using Portafolio_Web_2023.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio_Web_2023.Services
{
    /// <summary>
    /// Hereda de la interfaz IServicioEmailSendGrid
    /// </summary>
    public class ServicioEmailSendGrid : IServicioEmailSendGrid
    {
        #region Campos generados automáticamente    
        //Creado automáticamente como campo
        private readonly IConfiguration configuration;
        #endregion


        //Se crea un constructor para poder inicializar IConfiguration, esto para poder acceder y extraer a los valores en los
        //V#61 Proveedores de configuración.
        public ServicioEmailSendGrid(IConfiguration configuration) //Ctrl+. Create and assign field
        {
            //Creado automáticamente luego de ctrl + .
            this.configuration = configuration;
        }

        //Método asyncrono que recibira como parametros los datos del modelo ContactoViewModel
        public async Task Enviar(ContactoViewModel contactoViewModel) //Ctrl+. para implementar este método en la interfaz
        {
            //Obtenemos los valores de tipo string desde los Proveedores de configuración
            //"appsettings.Development.json"(area de desarrollo) a traves de IConfiguration 

            //Se obtiene y asigna el apiKey desde el V#61 Proveedores de configuración. 
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");

            //Se obtiene y asigna el correo remitente
            var email = configuration.GetValue<string>("SENDGRID_FROM");

            //Se obtiene y asigna el nombre del remitente(Notificación en mi caso)
            var name = configuration.GetValue<string>("SENDGRID_NAME");

            //Hacia donde se envia el email   
            var emailTo = configuration.GetValue<string>("SENDGRID_TO");

            //Nombre hacia donde va el email
            var nameTo = configuration.GetValue<string>("SENDGRID_NAME_TO");


            //Asignamos el apikey al cliente(Muestra error si no se importa correctamente la apikey)
            //El problema aquí era que tenia 2 referencias al paquete en el proyecto (Portafolio_Web_2023) doble clicl para abrir el arch
            var cliente = new SendGridClient(apiKey);//Importar
            //Pasamos el correo y nombre del remitente
            var from = new EmailAddress(email, name);//Importar libreria
            //Titulo o encabezado que se mostrará en la bandeja de entrada junto al Nombre
            //Castamos o concatenamos un texto
            var subject = $"¡{contactoViewModel.Nombre}, desea contactarte!";
            //A quien va dirijido el email(destinatario) nombre y email
            //Se recomienda usar solo correos que sean @gmail para no tener problemas por la api gratuita
            var to = new EmailAddress(emailTo, nameTo);
            //Asignamos el msj o contenido a una variable
            var mensajeTextoPlano = contactoViewModel.Mensaje;
            //A través de un string interbolation(@$) es posible agregar código HTML
            //Ya sea para personalizar el msj o poder mostrar una vista HTML
            var contenidoHTML = $@"<strong>De:</strong> {contactoViewModel.Nombre} 
                                <br/><br/> <strong>Email:</strong> {contactoViewModel.Email} 
                                <br/><br/> <strong>Mensaje:</strong> {contactoViewModel.Mensaje}";
            //Email único
            var msj = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, contenidoHTML);
            //Para poder enviar el email
            var respuesta = await cliente.SendEmailAsync(msj);
        }
    }
}
