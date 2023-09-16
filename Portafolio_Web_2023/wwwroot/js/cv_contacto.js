function child_hover1(child) {
    let parent = child.parentElement;

    if (!parent.classList.contains("hover_class_style1"))
        parent.classList.add("hover_class_style1");

    //if (!parent.classList.contains("hover_class_style1")) {
    //    parent.classList.add("hover_class_style1");
    //    /*parent = '';*/
    //    console.log('El valor de parent1 cont es: ' + parent);
    //}
    //else {
    //    if (!parent.classList.contains("hover_class_style2")) {
    //        parent.classList.add("hover_class_style2");
    //        console.log('El valor de parent2 cont es: ' + parent);
    //    }
    //}
    //else if (!parent.classList.contains("hover_class_style2")) {
    //    parent.classList.add("hover_class_style2");
    //}
    //else if (!parent.classList.contains("hover_class_style3")) {
    //    parent.classList.add("hover_class_style3");
    //}
        
}

function child_exit1(child) {
    
    let parent = child.parentElement;
   /* if (parent.classList.contains("hover_class_style1"))*/
            parent.classList.remove("hover_class_style1");


    //if (parent.classList.contains("hover_class_style1")) {
    //    parent.classList.remove("hover_class_style1");
    //    console.log('El valor de parent1 remove es: ' + parent);
    //}
    //else {
    //    if (parent.classList.contains("hover_class_style2")) {
    //        parent.classList.remove("hover_class_style2");
    //        console.log('El valor de parent2 remove es: ' + parent);
    //    }
    //}
    //else if (parent.classList.contains("hover_class_style2")) {
    //    parent.classList.remove("hover_class_style2");
    //}
    //else if (parent.classList.contains("hover_class_style3")) {
    //    parent.classList.remove("hover_class_style3");
    //}
    
}

//let childrens = document.querySelectorAll(".github");
//childrens.forEach(el => {
//    el.onmouseenter = () => child_hover(el);
//    el.onmouseout = () => child_exit(el);
//});


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