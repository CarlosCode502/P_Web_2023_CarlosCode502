//v#66 ENVIANDO EMAILS DESDE LA APP 02

using Portafolio_Web_2023.Models;

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
        }
    }
}
