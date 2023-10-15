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
        public List<CVsViewModel> ListadoArchivos()
        {
            return new List<CVsViewModel>(){
                new CVsViewModel
                {
                    Id = 1,
                    Nombre = "Cv simple."
                    //Ruta = "/Resources/Currículum Vitae Cv.pdf"
                },
                new CVsViewModel
                {
                    Id = 2,
                    Nombre = "Cv con diseño."
                    //Ruta = "/Resources/Currículum Vitae Cv.pdf"
                }
                //,
                //new ArchivosViewModel
                //{
                //    Id = 3,
                //    Name = "No c",
                //    Ruta = "Cpa"
                //}
            };
        }
    }
}
