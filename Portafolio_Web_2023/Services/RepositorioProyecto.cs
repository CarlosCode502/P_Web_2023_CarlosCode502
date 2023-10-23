using Portafolio_Web_2023.Models;

namespace Portafolio_Web_2023.Services
{
    public class RepositorioProyecto : IRepositorioProyecto
    {
        //V#56 Principio de responsabilidad Única
        //El principio de responsabilidad única nos dice que cada clase debe tener sólo un motivo para cambiar.
        //Y la función del controlador únicamente es preparar las vistas a mostrar en base a las peticiones

        //V#54 Listado de Proyectos
        /// <summary>
        /// Creamos un método que va a contener un listado de proyectos
        /// </summary>
        /// <returns>Un listado de proyectos</returns>
        //Public para que tengamos acceso desde la clase PortafolioController
        public List<ProyectoViewModel> ObtenerListadoProyectos()
        {
            //IMPORTANTE PONER LA MISMA CANTIDAD DE DESCRIPCIÓN(LINEAS)

            return new List<ProyectoViewModel>() {
                new ProyectoViewModel
                {
                    Titulo = "Sistema de registro de productos",
                    Descripcion = "Aplicación de WF en lenguaje C# utilizando POO arquitectura en N Capas y principios de Clean Architecture.",
                    Link = "https://github.com/CarlosCode502/Registro_NCapas_CRUD_POO_SQL.git",
                        ImagenURL = "/img/1.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Calculadora Científica-básica",
                    Descripcion = "Aplicación de Windows Forms en lenguaje C# que simula la función de una calculadora cientifíca-básica.",
                    Link = "https://github.com/CarlosCode502/CalculadoraCientifica.git",
                    ImagenURL = "/img/5.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Interés Simple y Compuesto",
                    Descripcion = "Programa echo en WindowsForms con C#, simula una herramienta para calcular el interés simple y compuesto.",
                    Link = "https://github.com/CarlosCode502/InteresSimple_Y_Compuesto.git",
                    ImagenURL = "/img/3.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "App de menú para restaurante",
                    Descripcion = "Aplicación de Consola en lenguaje C#, en donde se puede ver el funcionamiento de una orden en un restaurante/comedor",
                    Link = "https://github.com/CarlosCode502/App_Menu_Restaurante.git",
                    ImagenURL = "/img/4.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Sistema de registro de productos",
                    Descripcion = "Aplicación de WF en lenguaje C# utilizando POO arquitectura en N Capas y principios de Clean Architecture.",
                    Link = "https://github.com/CarlosCode502/Registro_NCapas_CRUD_POO_SQL.git",
                        ImagenURL = "/img/1.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Calculadora Científica-básica",
                    Descripcion = "Aplicación de Windows Forms en lenguaje C# que simula la función de una calculadora cientifíca-básica.",
                    Link = "https://github.com/CarlosCode502/CalculadoraCientifica.git",
                    ImagenURL = "/img/5.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Interés Simple y Compuesto",
                    Descripcion = "Programa echo en WindowsForms con C#, simula una herramienta para calcular el interés simple y compuesto.",
                    Link = "https://github.com/CarlosCode502/InteresSimple_Y_Compuesto.git",
                    ImagenURL = "/img/3.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "App de menú para restaurante",
                    Descripcion = "Aplicación de Consola en lenguaje C#, en donde se puede ver el funcionamiento de una orden en un restaurante/comedor",
                    Link = "https://github.com/CarlosCode502/App_Menu_Restaurante.git",
                    ImagenURL = "/img/4.jpg"
                }
            };
        }
    }
}
