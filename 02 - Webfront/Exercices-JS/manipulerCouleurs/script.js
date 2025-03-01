let fond = document.querySelector("body")
let inputRouge = document.querySelector("#inputRouge")
let inputVert = document.querySelector("#inputVert")
let inputBleu = document.querySelector("#inputBleu")

document.querySelector("#btnRouge").addEventListener("click", () => {
    fond.style.backgroundColor = "red"
})

document.querySelector("#btnVert").addEventListener("click", () => {
    fond.style.backgroundColor = "green"
})

document.querySelector("#btnBleu").addEventListener("click", () => {
    fond.style.backgroundColor = "blue"
})

inputRouge.addEventListener("change", () => {
    if (inputVert.value !== "" && inputBleu.value !== "") {
        fond.style.backgroundColor = "rgb(" + inputRouge.value + ", " + inputVert.value + ", " + inputBleu.value + ")"
    }
})

inputVert.addEventListener("change", () => {
    if (inputRouge.value !== "" && inputBleu.value !== "") {
        fond.style.backgroundColor = "rgb(" + inputRouge.value + ", " + inputVert.value + ", " + inputBleu.value + ")"
    }
})

inputBleu.addEventListener("change", () => {
    if (inputRouge.value !== "" && inputVert.value !== "") {
        fond.style.backgroundColor = "rgb(" + inputRouge.value + ", " + inputVert.value + ", " + inputBleu.value + ")"
    }
})