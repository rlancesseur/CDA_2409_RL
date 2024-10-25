let boutonPlus = document.querySelector("#augmente")
let boutonMoins = document.querySelector("#diminue")
let zoneTaille = document.querySelector("span")
let taille = parseInt(zoneTaille.textContent)
let paragraphe = document.querySelector("#text")

function augmenterTaille() {
    if(taille < 48) {
    taille++
    zoneTaille.innerText = taille
    paragraphe.style.fontSize = taille + "px"
    }
    else {
        taille = 16
        zoneTaille.innerText = taille
        paragraphe.style.fontSize = taille + "px"
    }
}

function diminuerTaille() {
    if(taille > 8) {
    taille--
    zoneTaille.innerText = taille
    paragraphe.style.fontSize = taille + "px"
    }
    else {
        taille = 16
        zoneTaille.innerText = taille
        paragraphe.style.fontSize = taille + "px"
    }
}

boutonPlus.addEventListener("click", augmenterTaille);
boutonMoins.addEventListener("click", diminuerTaille)

