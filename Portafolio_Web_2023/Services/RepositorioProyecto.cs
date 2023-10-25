﻿using Portafolio_Web_2023.Models;

namespace Portafolio_Web_2023.Services
{
    //V#56 Principio de responsabilidad Única
    //Una buena práctica ya que se esta separando la capa de acceso a datos centralizandola
    //en clases de tipo servicios o repositorios.

    /// <summary>
    /// Un repositorio es una clase que se encarga se servir datos que se conecta con una BD o
    /// para realizar alguna operación en la BD.
    /// </summary>
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
                    Titulo = "Portafolio Web",
                    Descripcion = "Este es mi portafolio en donde muestro los proyectos en los que he trabajado en las distintas tecnologías.",
                    Link = "https://github.com/CarlosCode502/Registro_NCapas_CRUD_POO_SQL.git",
                        ImagenURL = "/img/Portafolio.jpg"
                },

                new ProyectoViewModel
                {
                    Titulo = "Sistema de registro de productos",
                    Descripcion = "Aplicación de WF en lenguaje C# utilizando POO arquitectura en N Capas y principios de Clean Architecture.",
                    Link = "https://github.com/CarlosCode502/Registro_NCapas_CRUD_POO_SQL.git",
                        ImagenURL = "/img/Sistema de registro.PNG"
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
                    Descripcion = "Programa echo en WindowsForms con C#, simula una herramienta para calcular el interés simple y compuesto.",
                    Link = "https://github.com/CarlosCode502/InteresSimple_Y_Compuesto.git",
                    ImagenURL = "/img/Interés SyC.jpg" //Img de 720 / 580
                },

                new ProyectoViewModel
                {
                    Titulo = "App de menú para restaurante",
                    Descripcion = "Aplicación de Consola en lenguaje C#, en donde se puede ver el funcionamiento de una orden en un restaurante/comedor",
                    Link = "https://github.com/CarlosCode502/App_Menu_Restaurante.git",
                    ImagenURL = "/img/Sistema Menú Restaurante.jpg"//Img de 1080 / 540
                }
            };
        }
    }
}
