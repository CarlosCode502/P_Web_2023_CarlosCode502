//Evento OnClick que se ejecutara cuando se haga clic sobre el enlace Inicio(a href)
//click-inicio

//Obtiene el elemento de enlace con el id "click-inicio"
const enlace = document.getElementById("click-inicio");
//Agrega la función onclick al elemento 
enlace.onclick = aEscribir;

//Creamos la función
function aEscribir(evento) {
    //Para prevenir acciones por defecto se ejecuta.
    evento.preventDefault();

    document.write('~/js/Typed.js');
}