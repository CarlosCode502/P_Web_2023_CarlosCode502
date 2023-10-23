/*MODIFICADO (funciones y if individual)*/
function child_hover0(child) {
    let parent = child.parentElement;

    if (!parent.classList.contains("hover_class_style0"))
        parent.classList.add("hover_class_style0");
}

function child_exit0(child) {
    let parent = child.parentElement;
    parent.classList.remove("hover_class_style0");
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


//FUNCIÓN PARA MOSTRAR UNA ALERTA POR X TIEMPO Y CERRARLA AUTOMÁTICAMENTE
/*@* funcion js para mostrar un elemento y ocultarlo luego de unos segundos * @*/
function ocultarAlerta() {
    // $('.alert').animate({ opacity: "0" }, { duration: 1000, queue: false });
    //Cierra o oculta la alerta o elemento
    $('.alert').fadeOut();
}
setTimeout(function () {
    //en un intervalo de tiempo se lanza una funcion    
    ocultarAlerta();
}, 25000);// tiempo en ms para que se cierre la alerta.