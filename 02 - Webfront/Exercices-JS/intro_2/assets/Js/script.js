let boutonPlus = document.querySelector("#augmente")
let boutonMoins = document.querySelector("#diminue")
let zoneTaille = document.querySelector("#zoneTaille")
let taille = parseInt(zoneTaille.textContent)
let paragraphe = document.querySelector("#text")
let saisie = document.querySelector("#saisie")
let boutonValider = document.querySelector("#validerSaisie")


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

function saisirTaille() {
    if(saisie.value > 7 && saisie.value < 49) {
        taille = saisie.value
        zoneTaille.innerText = taille
        paragraphe.style.fontSize = taille + "px"
    }
    else {
        alert("Veuillez entrer un nombre entre 8 et 48.");
      }
}

boutonPlus.addEventListener("click", augmenterTaille)
boutonMoins.addEventListener("click", diminuerTaille)
boutonValider.addEventListener("click", saisirTaille)
