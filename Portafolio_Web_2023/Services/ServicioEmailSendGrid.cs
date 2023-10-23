using Portafolio_Web_2023.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio_Web_2023.Services
{
    public class ServicioEmailSendGrid : IServicioEmailSendGrid
    {
        #region Campos generados automáticamente    
        //Creado automáticamente como campo
        private readonly IConfiguration configuration;
        #endregion

        public ServicioEmailSendGrid(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contactoViewModel)
        {

            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");

            var email = configuration.GetValue<string>("SENDGRID_FROM");

            var name = configuration.GetValue<string>("SENDGRID_NAME");

            var emailTo = configuration.GetValue<string>("SENDGRID_TO");

            var nameTo = configuration.GetValue<string>("SENDGRID_NAME_TO");


            var cliente = new SendGridClient(apiKey);//Importar

            var from = new EmailAddress(email, name);//Importar libreria

            var subject = $"¡{contactoViewModel.Nombre}, desea contactarte!";
 
            var to = new EmailAddress(emailTo, nameTo);

            var mensajeTextoPlano = contactoViewModel.Mensaje;

            var contenidoHTML = $@"<strong>De:</strong> {contactoViewModel.Nombre} 
                                <br/><br/> <strong>Email:</strong> {contactoViewModel.Email} 
                                <br/><br/> <strong>Mensaje:</strong> {contactoViewModel.Mensaje}";
            //Email único
            var msj = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, contenidoHTML);
            var respuesta = await cliente.SendEmailAsync(msj);
        }
    }
}
