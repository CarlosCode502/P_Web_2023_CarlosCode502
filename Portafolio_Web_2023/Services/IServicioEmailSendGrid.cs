using Portafolio_Web_2023.Models;

namespace Portafolio_Web_2023.Services
{
    public interface IServicioEmailSendGrid
    {
        Task Enviar(ContactoViewModel contactoViewModel);
    }
}
