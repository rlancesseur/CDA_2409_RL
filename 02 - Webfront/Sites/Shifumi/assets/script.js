const btnCommencer = document.querySelector("#btnCommencer")
const wrapper = document.querySelector("#wrapper")
const zoneScore = document.querySelector("#zoneScore")
const zoneResultat = document.querySelector("#zoneResultat")
const imgPierre = document.querySelector("#imgPierre")
const imgPapier = document.querySelector("#imgPapier")
const imgCiseaux = document.querySelector("#imgCiseaux")
let affichageGagnant = document.createElement("p")

let saisieUtilisateur = 0

imgPierre.addEventListener("click", () => {
    saisieUtilisateur = 1
    nouvellePartie()
})
imgPapier.addEventListener("click", () => {
    saisieUtilisateur = 2
    nouvellePartie()
})
imgCiseaux.addEventListener("click", () => {
    saisieUtilisateur = 3
    nouvellePartie()
})

btnCommencer.addEventListener("click", () => {
    btnCommencer.style.display = "none"
    wrapper.style.display = "flex"
    zoneScore.style.display = "flex"
    zoneResultat.style.display = "none"
})


const nouvellePartie = () => {
    let zoneScoreUtilisateur = document.querySelector("#zoneScoreUtilisateur")
    let zoneScoreOrdinateur = document.querySelector("#zoneScoreOrdinateur")
    let scoreUtilisateur = 0
    let scoreOrdinateur = 0
    zoneScoreUtilisateur.innerText = scoreUtilisateur
    zoneScoreOrdinateur.innerText = scoreOrdinateur

    while(scoreUtilisateur < 3 && scoreOrdinateur < 3) {

        let saisieOrdinateur = Math.ceil(Math.random() * 3)

        if ((saisieUtilisateur === 1 && saisieOrdinateur === 3) ||
            (saisieUtilisateur === 2 && saisieOrdinateur === 1) ||
            (saisieUtilisateur === 3 && saisieOrdinateur === 2)) {
            scoreUtilisateur++
        }
        else if ((saisieUtilisateur === 1 && saisieOrdinateur === 2) ||
                (saisieUtilisateur === 2 && saisieOrdinateur === 3) ||
                (saisieUtilisateur === 3 && saisieOrdinateur === 1)) {
                scoreOrdinateur++
        }

            zoneScoreUtilisateur.innerText = scoreUtilisateur
            zoneScoreOrdinateur.innerText = scoreOrdinateur
    }

    saisieUtilisateur = 0
    saisieOrdinateur = 0

    wrapper.style.display = "none"
    zoneScore.style.display = "none"
    zoneResultat.style.display = "block"

    if(scoreUtilisateur === 3) {
        affichageGagnant.innerText = "Vous avez gagné !"
    }
    else if(scoreOrdinateur === 3) {
        affichageGagnant.innerText = "Vous avez perdu !"
    }
    zoneResultat.appendChild(affichageGagnant)

    btnCommencer.style.display = "block"
}

