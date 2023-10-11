using Humanizer.Localisation;
using Microsoft.AspNetCore.Hosting.Server;
using Portafolio_Web_2023.Models;
using System.IO.Pipes;
using System.Security.Policy;

namespace Portafolio_Web_2023.Services
{
    public class RepositorioArchivos : IRepositorioArchivos
    {
        //Lista que contiene el nombre y la ruta de mis archivos
        public List<ArchivosViewModel> ListadoArchivos()
        {
            return new List<ArchivosViewModel>(){
                new ArchivosViewModel
                {
                    Id = 1,
                    Name = "Cv con diseño HTML.",
                    Ruta = "/Resources/Currículum Vitae Cv.pdf"
                },
                new ArchivosViewModel
                {
                    Id = 2,
                    Name = "Cv hecho en Canva.",
                    Ruta = "/Resources/Currículum Vitae Cv.pdf"
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
