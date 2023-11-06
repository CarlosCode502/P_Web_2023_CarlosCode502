
const menu = document.getElementById('nav_menu_id');
let indicador = document.getElementById('indicador_id');

let secciones = document.querySelectorAll('#Inicio, #Perfil, #Habilidades, #Proyectos_recientes, #Contacto');

let tamanioIndicador = menu.querySelector('a').offsetWidth;

indicador.style.width = tamanioIndicador + 'px';

let indexSeccionAcctiva;

let rootmargin_V = '-100px 0px 0px 0px';
let threshold_V = 0.55;

const observer = new IntersectionObserver((entradas, observer) => {
   
    entradas.forEach(entrada => {
       
        if (entrada.isIntersecting) {

            indexSeccionAcctiva = [...secciones].indexOf(entrada.target);

            let tamanioIndicador = menu.querySelector('a').offsetWidth;
           
            indicador.style.width = tamanioIndicador + 'px';

            indicador.style.transform = `translateX(${tamanioIndicador * indexSeccionAcctiva}px)`;
        }
    });
}, {
   
    rootMargin: rootmargin_V,
   
    threshold: threshold_V
});

secciones.forEach(seccion => observer.observe(seccion));


let onResize = () => {
  
    tamanioIndicador = menu.querySelector('a').offsetWidth;
 
    indicador.style.width = `${tamanioIndicador}px`;
    
    indicador.style.transform = `translateX(${tamanioIndicador * indexSeccionAcctiva}px)`;
 
}

//accedemos a la ventana para escuachar cuando hay algun cambio en tamaño
window.addEventListener('resize', onResize);


//Funcion para mostrar y ocultar el botón flotante segun el scroll
btnIni.onclick = function () {
    window.scrollTo(this.scrollY, 0);
    //window.scrollTo(pageYOffset, 0); Anterior ya esta obsoleto la solución reemplazarlo con scrollY

    // después de scrollTo, habrá un evento "scroll", entonces la flecha se ocultará automáticamente
};

window.addEventListener('scroll', function () {
    btnIni.hidden = (this.scrollY < document.documentElement.clientHeight);
});
