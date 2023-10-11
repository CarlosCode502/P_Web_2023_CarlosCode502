using Portafolio_Web_2023.Models;

namespace Portafolio_Web_2023.Services
{
    public class RepositorioArchivos : IRepositorioArchivos
    {
        public List<ArchivosViewModel> ListadoArchivos()
        {
            return new List<ArchivosViewModel>(){
                new ArchivosViewModel
                {
                    Id = 1,
                    Name = "Cv con diseño HTML.",
                    Ruta = "Algún lado"
                },
                new ArchivosViewModel
                {
                    Id = 2,
                    Name = "Cv hecho en Canva.",
                    Ruta = "Algún otro lado"
                },
                new ArchivosViewModel
                {
                    Id = 3,
                    Name = "No c",
                    Ruta = "Cpa"
                }
            };
        }
    }
}
