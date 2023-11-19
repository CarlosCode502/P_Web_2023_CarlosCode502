//La libreria Typed.js
//Corresponde al creador Matt Boldt -> https://github.com/mattboldt

//DE ESTA MANERA ES POSIBLE QUE LOS BUSCADORES DE GOOGLE ÚBIQUEN LA WEB
/*AQUI ABAJO ESTA TODO EL CODIGO DE MI ANIMACIÓN ESCRITURA*/
//'.typed-name' corresponde a la clase del span
const typed_name = new Typed('.typed-name', {
    //'#cadenas-texto' corresponde al id del contenedor que tiene los textos que s van a mostrar
    stringsElement: '#cadenas-texto',// ID del elemento que contiene cadenas de texto a mostrar.
    typeSpeed: 50, // Velocidad en mlisegundos para poner una letra,
    startDelay: 300, // Tiempo de retraso en iniciar la animacion. Aplica tambien cuando termina y vuelve a iniciar,
    backSpeed: 50, // Velocidad en milisegundos para borrar una letra,
    smartBackspace: true, // Eliminar solamente las palabras que sean nuevas en una cadena de texto. en true no se elimina la nueva p de la f2
    shuffle: false, // Alterar el orden en el que escribe las palabras.
    backDelay: 4000, // Tiempo de espera despues de que termina de escribir una palabra.
    loop: true, // Repetir el array de strings
    loopCount: false, // Cantidad de veces a repetir el array.  false = infinite
    showCursor: true, // Mostrar cursor palpitanto
    cursorChar: '&#124', // Caracter para el cursor
    /*bindInputFocusEvents: true,*/
    contentType: 'html', // 'html' o 'null' para texto sin formato
});