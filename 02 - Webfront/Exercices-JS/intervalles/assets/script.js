let boutonAfficher = document.querySelector("#boutonAfficher")
let affichageActu = document.querySelector("#affichageActu")

let boutonIntervalle = document.querySelector("#boutonIntervalle")
let affichageIntervalle = document.querySelector("#AffichageIntervalle")

function afficherActu() {
    let dateActu = new Date(document.querySelector("#dateActu").value)
    let heureActu = document.querySelector("#heureActu").value
    let joursActu = dateActu.getDate()
    let moisActu = dateActu.getMonth() + 1
    let anneeActu = dateActu.getFullYear()

    affichageActu.innerHTML = "Aujourd'hui nous sommes le " + joursActu + "/" + moisActu + "/" + anneeActu + ", l'heure courante est : " + heureActu + "."
}

function afficherIntervalle() {
    let dateHeureUtilisateur = new Date(document.querySelector("#dateHeureUtilisateur").value)
    let jours = dateHeureUtilisateur.getDate()
    let mois = dateHeureUtilisateur.getMonth() + 1
    let annee = dateHeureUtilisateur.getFullYear()
    let heures = dateHeureUtilisateur.getHours()
    let minutes = dateHeureUtilisateur.getMinutes()
    let intervalle = 0

    if(dateHeureUtilisateur > dateActu) {
        intervalle = dateHeureUtilisateur - dateActu
    }
    else {
        intervalle = dateActu - dateHeureUtilisateur
    }

    affichageIntervalle.innerHTML = "Il y a " + intervalle + " entre aujourd'hui et le " + jours + "/" + mois + "/" + annee + " à " + heures + ":" + minutes + ":" + "."
}

boutonAfficher.addEventListener("click", afficherActu)
boutonIntervalle.addEventListener("click", afficherIntervalle)