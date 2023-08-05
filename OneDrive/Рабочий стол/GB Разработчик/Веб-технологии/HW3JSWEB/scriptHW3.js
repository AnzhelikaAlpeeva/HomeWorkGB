let flag = false;

function changeColor() {
    let element = document.getElementById("el1");
    if (flag) {
        element.classList.add("fire");
        flag = false;
    }
    else {
        element.classList.remove("fire");
        flag = true;
    }
    console.log(element)
    element.classList.toggle("fire"); 
    element.textContent = element.textContent == "Разметка в HTML осуществляется с помощью тегов" ? "Ты нашел то, что искал - новые знания!:)" : "Разметка в HTML осуществляется с помощью тегов";
}

let btn = document.getElementById("el2");
console.log(btn); 
btn.addEventListener('click', changeColor) 