using Portafolio_Web_2023.Models;

namespace Portafolio_Web_2023.Services
{
    public class RepositorioProyecto : IRepositorioProyecto
    {
        public List<ProyectoViewModel> ObtenerListadoProyectos()
        {
            return new List<ProyectoViewModel>() {
                new ProyectoViewModel
                {
                    Titulo = "Portafolio Web",
                    Descripcion = "Este es mi portafolio en donde muestro los proyectos en los que he trabajado en las distintas tecnologías.",
                    Link = "https://github.com/CarlosCode502/P_Web_2023_CarlosCode502.git",
                        ImagenURL = "/img/Portafolio.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Sistema de registro de productos",
                    Descripcion = "Aplicación de WF en lenguaje C# utilizando POO arquitectura en N Capas y principios de Clean Architecture.",
                    Link = "https://github.com/CarlosCode502/Registro_NCapas_CRUD_POO_SQL.git",
                        ImagenURL = "/img/Sistema r.png"
                },

                new ProyectoViewModel
                {
                    Titulo = "Calculadora Científica-básica",
                    Descripcion = "Aplicación de Windows Forms en lenguaje C# que simula la función de una calculadora cientifíca-básica.",
                    Link = "https://github.com/CarlosCode502/CalculadoraCientifica.git",
                    ImagenURL = "/img/calculadora-basica.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Interés Simple y Compuesto",
                    Descripcion = "Programa hecho en WindowsForms con C#, simula una herramienta para calcular el interés simple y compuesto.",
                    Link = "https://github.com/CarlosCode502/InteresSimple_Y_Compuesto.git",
                    ImagenURL = "/img/Interés SyC.jpg" //Img de 720 / 580
                },

                new ProyectoViewModel
                {
                    Titulo = "App de menú para restaurante",
                    Descripcion = "Aplicación de Consola en lenguaje C#, en donde se puede ver el funcionamiento de una orden en un restaurante/comedor",
                    Link = "https://github.com/CarlosCode502/App_Menu_Restaurante.git",
                    ImagenURL = "/img/menu-restaurante.jpg"
                }
            };
        }
    }
}
