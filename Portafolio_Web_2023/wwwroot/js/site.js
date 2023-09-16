// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Obtener y asignar el menu para poder obtener los datos
const menu = document.getElementById('nav_menu_id');//Se debe especificar el id del menú
let indicador = document.getElementById('indicador_id');//especificamos el id del identificador
//va a contener todas las secciones que tiene mi pagina con "querySelectorAll"
let secciones = document.querySelectorAll('#Inicio, #Perfil, #Habilidades, #Proyectos_recientes, #Contacto');//ADJUNTAR TODAS NUESTRAS SECCIONES SIN IMPORTAR EL TIPO TENER CUIDADO
/*console.log(secciones);*///obtenemos un nodo que contiene los elementos de secciones
//Obtener el tamaño de nuestro indicador (let) ya que el tamaño va a cambiar
//accedemos al indicador actual (no a todos)
let tamanioIndicador = menu.querySelector('a').offsetWidth;
/*console.log(tamanioIndicador);*/ //Obtiene el tamaño del indicador
//indicador > estilos > ancho = tm del indicador
indicador.style.width = tamanioIndicador + 'px';


//Para obtener el index de la sección actual o activa
let indexSeccionAcctiva;

//Personal calcular el threshold y rootmargin
let rootmargin_V = '-100px 0px 0px 0px';
let threshold_V = 0.65;

//Identificar en que seccion se encuentra
//Para esto se va a utilizar (IntersectorObserver) para detectar en que seccion estoy
//Este es un observador
const observer = new IntersectionObserver((entradas, observer) => {
    //console.log(entradas);//muestra la seccion actual en consola

    //Identificar elemento o seccion que entro en pantalla
    //por cada entrada ejecutame una función
    entradas.forEach(entrada => {
        //Pero necesitamos que por cada entrada se ejecute una condición que verifica si se esta mostrando en pantalla
        if (entrada.isIntersecting) {

            //Se obtiene el elemento que esta en pantalla y se compara en el arreglo si existe se extrae el indice 
            //y en base al indice se manda a la úbicación el indicador
            //Primero se debe transformar las secciones en un arreglo(min 40:32)
            indexSeccionAcctiva = [...secciones].indexOf(entrada.target);//Operador esspred lo convierte en arreglo para ob el indice
            /*console.log(indexSeccionAcctiva);*/

            let tamanioIndicador = menu.querySelector('a').offsetWidth;
            //console.log('Este es el tam desde el observer' + tamanioIndicador);
            //if (indexSeccionAcctiva == 0) {
            //    indicador.style.transform = `translateX(-500px)`;
            //}

            //verifica cual se muestra en pantalla
            /*se ejecuta por cada entrada se muestra en consola*/
            /*console.log(entrada.target)*///Imprime todas las entradas según se este recorriendo

            //indicador > estilos > ancho = tm del indicador
            /*indicador.style.width = tamanioIndicador + 10;*/
            indicador.style.width = tamanioIndicador + 'px';
/*            console.log('El valor de width es: completa ' + indicador.style.width);*/

            //accedemos al estilo del indicador luego a su transform para transformarlo en traslare en eje de x
            /*indicador.style.transform = 'translateX(500px)';*///CAMBIAMOS PARA ADMITIR VALORES DE JS
            //Posición del indicador
            indicador.style.transform = `translateX(${tamanioIndicador * indexSeccionAcctiva}px)`;//Alt+96 para añadir(Backsticks)
            /*console.log('la sección activa su indice es: ' + indexSeccionAcctiva);*/
        }
    });
}, {
    //Un segundo parametros en donde es posible indicar los márgenes
    //Esto para que tome en centa el espacio del nav ya que este se encuentra sobre 80 px
    rootMargin: rootmargin_V,
    //Permite ejecutar el código según la parte de la sección que se muestre
    //Es decir que permite definir si cambiar el indicador cuando se este en el 20% de la sección y sucesivamente
    threshold: threshold_V//Equivale al 60%
    /*60% para pantallas grandes*/
});
/*console.log(threshold_V, rootmargin_V);*/


//OBSERVADOR PARA EL INICIO (min 48:28)
/*observer.observe(document.getElementById('.hero'));*/


//Asignamos un observador a cada una de las secciones
//por cada una de las secciones le va a llamar seccion de nombre
//va a ejecutar una funcion por cada seccion simplemente observarla
//secciones.forEach(seccion => {
//    observer.observe(seccion)
//});
//Foreach que ejecuta una función por cada seccion que tengamos 
secciones.forEach(seccion => observer.observe(seccion));


//Evento para detectar cuando la pantalla cambie de tamaño
let onResize = () => {

    /*indexSeccionAcctiva = [...secciones].indexOf(entrada.target);//Operador esspred lo convierte en arreglo para ob el indice*/

    /*console.log('pantalla cambio a' + onResize);*/
    //Calcula el nuevo tamaño que tendra nuestro indicador
    tamanioIndicador = menu.querySelector('a').offsetWidth;

    //console.log('el tamaño del indicador es:' + tamanioIndicador);

    //cambiamos el tamaño del indicador
    /*indicador.style.width = tamanioIndicador + 10;*/
    indicador.style.width = `${tamanioIndicador}px`;
    /*console.log('El valor de width es resize: ' + indicador.style.width);*/
    /*    console.log('El valor del nuevo resize es' + indicador.style.width)*/
    //console.log(indicador.style.width = `${tamanioIndicador}px`);
    //Se vuelve a posicionar el indicador
    indicador.style.transform = `translateX(${tamanioIndicador * indexSeccionAcctiva}px)`;
    /*console.log(indicador.style.transform = `translateX(${tamanioIndicador * indexSeccionAcctiva}px)`);*/
    /*threshold_V = 0.*/
}

//accedemos a la ventana para escuachar cuando hay algun cambio en tamaño
window.addEventListener('resize', onResize);




