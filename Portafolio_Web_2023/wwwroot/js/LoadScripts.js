//let scriptFile = document.createElement("script");


//scriptEle.setAttribute("~/js/Typed.js", FILE_URL);
//scriptEle.setAttribute("type", "text/javascript");
//scriptEle.setAttribute("async", async);

//document.body.appendChild(scriptFile);

//scriptFile.addEventListener("load", () => {
//    console.log("File loaded")
//});

//scriptFile.addEventListener("error", (ev) => {
//    console.log("Error no se cargo el archivo", ev)
//});

//const url = '~/js/Typed.js';

//const callback = aEscribir

//function loadScript(url, callback) {

//    var head = document.getElementsByTagName('head')[0];
//    var script = document.createElement('script');
//    script.type = 'text/javascript';
//    script.src = url;
//    script.onreadystatechange = callback;
//    script.onload = callback;
//    head.appendChild(script);
//}


////Evento OnClick que se ejecutara cuando se haga clic sobre el enlace Inicio(a href)
////click-inicio

////Obtiene el elemento de enlace con el id "click-inicio"
//const enlace = document.getElementById('click-inicio');
////Agrega la función onclick al elemento
//enlace.onclick = aEscribir;

////Creamos la función
//function aEscribir(evento) {
//    //Para prevenir acciones por defecto se ejecuta.
//    evento.preventDefault();
//    alert('Archivo cargado');
//    /*document.write('~/js/Typed.js');*/
//    /*<script src="~/js/Typed.js" asp-append-version="true"></script>*/
//    /*document.write('<script src="~/js/Typed.js" asp-append-version="true"></script>');*/
//}



//var loadJS = function (url, implementationCode, location) {
//    let url = 'https://unpkg.com/typed.js@2.0.16/dist/typed.umd.js';
//    //url es la URL del archivo externo, implementaciónCode es el código
//    //para ser llamado desde el archivo, la ubicación es la ubicación a
//    //inserta el elemento <script>

//    var scriptTag = document.createElement('script');
//    scriptTag.src = url;

//    scriptTag.onload = implementationCode;
//    scriptTag.onreadystatechange = implementationCode;

//    location.appendChild(scriptTag);
//};
//var yourCodeToBeCalled = function () {
//    //tu código va aquí
//}
//loadJS('yourcode.js', yourCodeToBeCalled, document.body);