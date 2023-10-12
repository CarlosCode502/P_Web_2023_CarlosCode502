/*MODIFICADO (funciones y if individual)*/
function child_hover0(child) {
    let parent = child.parentElement;

    if (!parent.classList.contains("hover_class_style0"))
        parent.classList.add("hover_class_style0");

    //    //if (!parent.classList.contains("hover_class_style1")) {
    //    //    parent.classList.add("hover_class_style1");
    //    //    /*parent = '';*/
    //    //    console.log('El valor de parent1 cont es: ' + parent);
    //    //}
    //    //else {
    //    //    if (!parent.classList.contains("hover_class_style2")) {
    //    //        parent.classList.add("hover_class_style2");
    //    //        console.log('El valor de parent2 cont es: ' + parent);
    //    //    }
    //    //}
    //    //else if (!parent.classList.contains("hover_class_style2")) {
    //    //    parent.classList.add("hover_class_style2");
    //    //}
    //    //else if (!parent.classList.contains("hover_class_style3")) {
    //    //    parent.classList.add("hover_class_style3");
    //    //}

}

function child_exit0(child) {

    let parent = child.parentElement;
    /* if (parent.classList.contains("hover_class_style1"))*/
    parent.classList.remove("hover_class_style0");


    //    //if (parent.classList.contains("hover_class_style1")) {
    //    //    parent.classList.remove("hover_class_style1");
    //    //    console.log('El valor de parent1 remove es: ' + parent);
    //    //}
    //    //else {
    //    //    if (parent.classList.contains("hover_class_style2")) {
    //    //        parent.classList.remove("hover_class_style2");
    //    //        console.log('El valor de parent2 remove es: ' + parent);
    //    //    }
    //    //}
    //    //else if (parent.classList.contains("hover_class_style2")) {
    //    //    parent.classList.remove("hover_class_style2");
    //    //}
    //    //else if (parent.classList.contains("hover_class_style3")) {
    //    //    parent.classList.remove("hover_class_style3");
    //    //}

}

/*MODIFICADO (funciones y if individual)*/
function child_hover1(child) {
    let parent = child.parentElement;

    if (!parent.classList.contains("hover_class_style1"))
        parent.classList.add("hover_class_style1");
}

function child_exit1(child) {
    let parent = child.parentElement;
    parent.classList.remove("hover_class_style1");
}



function child_hover2(child) {
    let parent = child.parentElement;
    if (!parent.classList.contains("hover_class_style2"))
        parent.classList.add("hover_class_style2");
}

function child_exit2(child) {
    let parent = child.parentElement;
    parent.classList.remove("hover_class_style2");
}



function child_hover3(child) {
    let parent = child.parentElement;
    if (!parent.classList.contains("hover_class_style3"))
        parent.classList.add("hover_class_style3");
}

function child_exit3(child) {
    let parent = child.parentElement;
    parent.classList.remove("hover_class_style3");
}



function child_hover4(child) {
    let parent = child.parentElement;
    if (!parent.classList.contains("hover_class_style4"))
        parent.classList.add("hover_class_style4");
}

function child_exit4(child) {
    let parent = child.parentElement;
    parent.classList.remove("hover_class_style4");
}

///*Aqui*/
///*3 en uno*/
//function child_hover(child) {
//    let parent = child.parentElement;

//    if (!parent.classList.contains("hover_class_style1")) {
//        parent.classList.add("hover_class_style1");
//    }
//    else {
//        if (!parent.classList.contains("hover_class_style2")) {
//            parent.classList.add("hover_class_style2");
//        }
//        else {
//            if (!parent.classList.contains("hover_class_style3")) {
//                parent.classList.add("hover_class_style3");
//            }
//        }
//    }
//}

//function child_exit(child) {
//    let parent = child.parentElement;

//    if (!parent.classList.contains("hover_class_style1")) {
//        parent.classList.remove("hover_class_style1");
//        parent = null;
//    }
//    else {
//        if (!parent.classList.contains("hover_class_style2")) {
//            parent.classList.remove("hover_class_style2");
//            parent = null;
//        }
//        else {
//            if (!parent.classList.contains("hover_class_style3")) {
//                parent.classList.remove("hover_class_style3");
//                parent = null;
//            }
//        }
//    }
//}

//let childrens = document.querySelectorAll(".contacto>a");
//childrens.forEach(el => {
//    el.onmouseenter = () => child_hover(el);
//    el.onmouseout = () => child_exit(el);
//});



///*NUEVA VERSION (Se queria implementar el observador pero observa todos al mismo tiempo)*/
//let padre = document.getElementById('contacto-padre');
//let hijos = document.querySelectorAll('.gmail, .github, .phone');

////obtenemos el indice del seleccionado
//let indexSeleccionado = [...hijos].indexOf;

////Personal calcular el threshold y rootmargin
//let rootmargin_V = '-100px 0px 0px 0px';
//let threshold_V = 0.65;

////Identificar en que seccion se encuentra
////Para esto se va a utilizar (IntersectorObserver) para detectar en que seccion estoy
////Este es un observador
//const observer = new IntersectionObserver((entradas, observer) => {
//    //console.log(entradas);//muestra la seccion actual en consola

//    //Identificar elemento o seccion que entro en pantalla
//    //por cada entrada ejecutame una función
//    entradas.forEach(entrada => {
//        //Pero necesitamos que por cada entrada se ejecute una condición que verifica si se esta mostrando en pantalla
//        if (entrada.isIntersecting) {

//            //Se obtiene el elemento que esta en pantalla y se compara en el arreglo si existe se extrae el indice
//            //y en base al indice se manda a la úbicación el indicador
//            //Primero se debe transformar las secciones en un arreglo(min 40:32)
//            indexSeleccionado = [...hijos].indexOf(entrada.target);//Operador esspred lo convierte en arreglo para ob el indice
//            console.log("EL indice del elmt seleccionado es: "+indexSeleccionado);



//            //let tamanioIndicador = menu.querySelector('a').offsetWidth;
//            //console.log('Este es el tam desde el observer' + tamanioIndicador);
//            //if (indexSeccionAcctiva == 0) {
//            //    indicador.style.transform = `translateX(-500px)`;
//            //}

//            //verifica cual se muestra en pantalla
//            /*se ejecuta por cada entrada se muestra en consola*/
//            /*console.log(entrada.target)*///Imprime todas las entradas según se este recorriendo

//            //indicador > estilos > ancho = tm del indicador
//            /*indicador.style.width = tamanioIndicador + 10;*/
//            //indicador.style.width = tamanioIndicador + 'px';
//            /*            console.log('El valor de width es: completa ' + indicador.style.width);*/

//            //accedemos al estilo del indicador luego a su transform para transformarlo en traslare en eje de x
//            /*indicador.style.transform = 'translateX(500px)';*///CAMBIAMOS PARA ADMITIR VALORES DE JS
//            //Posición del indicador
//            //indicador.style.transform = `translateX(${tamanioIndicador * indexSeccionAcctiva}px)`;//Alt+96 para añadir(Backsticks)
//            /*console.log('la sección activa su indice es: ' + indexSeccionAcctiva);*/
//        }
//    });
//}, {
//    //Un segundo parametros en donde es posible indicar los márgenes
//    //Esto para que tome en centa el espacio del nav ya que este se encuentra sobre 80 px
//    rootMargin: rootmargin_V,
//    //Permite ejecutar el código según la parte de la sección que se muestre
//    //Es decir que permite definir si cambiar el indicador cuando se este en el 20% de la sección y sucesivamente
//    threshold: threshold_V//Equivale al 60%
//    /*60% para pantallas grandes*/
//});

////Asignamos un observador a cada una de las secciones
////por cada una de las secciones le va a llamar seccion de nombre
////va a ejecutar una funcion por cada seccion simplemente observarla
////secciones.forEach(seccion => {
////    observer.observe(seccion)
////});
////Foreach que ejecuta una función por cada seccion que tengamos
//hijos.forEach(seccion => observer.observe(seccion));


//function child_hover3(child) {
//    let parent = child.parentElement;
//    hijos = [...hijos];

//    /*Muestra la longitud de elementos que contien hijos*/
//    console.log("Los ekementos son: " + hijos.length);

//    if (!parent.classList.contains("hover_class_style3"))
//        parent.classList.add("hover_class_style3");
//}

//function child_exit3(child) {
//    let parent = child.parentElement;
//    parent.classList.remove("hover_class_style3");
//}





