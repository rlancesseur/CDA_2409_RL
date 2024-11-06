let boutonAfficher = document.querySelector("#boutonAfficher")
let affichageActu = document.querySelector("#affichageActu")

let boutonIntervalle = document.querySelector("#boutonIntervalle")
let affichageIntervalle = document.querySelector("#AffichageIntervalle")

function afficherActu() {
    let dateActu = document.querySelector("#dateActu").value
    let heureActu = document.querySelector("#heureActu").value

    affichageActu.innerHTML = "Aujourd'hui nous sommes le " + dateActu + ", l'heure courante est : " + heureActu + "."
}

function afficherIntervalle() {
    let dateHeureUtilisateur = document.querySelector("#dateHeureUtilisateur").value
    let dateHeureSplit = dateHeureUtilisateur.split("T")
    let intervalle = 0

    if(dateHeureUtilisateur > dateActu) {
        intervalle = dateHeureSplit[0] - dateActu
    }
    else {
        intervalle = dateActu - dateHeureSplit[0]
    }

    affichageIntervalle.innerHTML = "Il y a " + intervalle + " entre aujourd'hui et le " + dateHeureSplit[0] + " à " + dateHeureSplit[1] + "."
}

boutonAfficher.addEventListener("click", afficherActu)
boutonIntervalle.addEventListener("click", afficherIntervalle)