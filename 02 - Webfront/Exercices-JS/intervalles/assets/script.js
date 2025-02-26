const boutonAfficher = document.querySelector("#boutonAfficher")
const affichageActu = document.querySelector("#affichageActu")

const boutonIntervalle = document.querySelector("#boutonIntervalle")
let affichageIntervalle = document.querySelector("#AffichageIntervalle")

const afficherActu = () => {
    let dateActu = new Date(document.querySelector("#dateActu").value)
    let heureActu = document.querySelector("#heureActu").value
    let joursActu = dateActu.getDate()
    let moisActu = dateActu.getMonth()
    let anneeActu = dateActu.getFullYear()

    afficherMois(moisActu)

    affichageActu.innerHTML = "Aujourd'hui nous sommes le " + joursActu + " " + scriptMois + " " + anneeActu + ", l'heure courante est : " + heureActu + "."
}

const afficherIntervalle = () => {
    const dateHeureUtilisateur = new Date(document.querySelector("#dateHeureUtilisateur").value)
    const dateActu = new Date(document.querySelector("#dateActu").value)
    let jours = dateHeureUtilisateur.getDate()
    let mois = dateHeureUtilisateur.getMonth()
    let annee = dateHeureUtilisateur.getFullYear()
    let heures = dateHeureUtilisateur.getHours()
    let minutes = dateHeureUtilisateur.getMinutes()
    let intervalle = 0

    afficherMois(mois)

    if(dateHeureUtilisateur > dateActu) {
        intervalle = Math.round((dateHeureUtilisateur - dateActu) / 86400000)
        affichageIntervalle.innerHTML = "Dans " + intervalle + " jours, nous serons le " + jours + " " + scriptMois + " " + annee + " à " + heures + ":" + minutes + "."
    }
    else {
        intervalle = Math.round((dateActu - dateHeureUtilisateur) / 86400000)
        affichageIntervalle.innerHTML = "Il y a " + intervalle + " jours, nous étions le " + jours + " " + scriptMois + " " + annee + " à " + heures + ":" + minutes + "."
    }
}

const afficherMois = (mois) => {
    const tableauMois = ["Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"]
    for(let i = 0; i < tableauMois.length; i++) {
        if(mois === i) {
            scriptMois = tableauMois[i]
        }
    }
}

boutonAfficher.addEventListener("click", afficherActu)
boutonIntervalle.addEventListener("click", afficherIntervalle)