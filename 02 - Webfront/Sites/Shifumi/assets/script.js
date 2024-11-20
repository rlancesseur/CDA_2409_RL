const btnCommencer = document.querySelector("#btnCommencer")
const wrapper = document.querySelector("#wrapper")
const zoneCombat = document.querySelector("#zoneCombat")
let imgUtilisateur = document.querySelector("#imgUtilisateur")
let imgOrdinateur = document.querySelector("#imgOrdinateur")
const zoneScore = document.querySelector("#zoneScore")
const zoneResultat = document.querySelector("#zoneResultat")
const zoneScoreUtilisateur = document.querySelector("#zoneScoreUtilisateur")
const zoneScoreOrdinateur = document.querySelector("#zoneScoreOrdinateur")
const imgPierre = document.querySelector("#imgPierre")
const imgPapier = document.querySelector("#imgPapier")
const imgCiseaux = document.querySelector("#imgCiseaux")
let affichageGagnant = document.createElement("p")
let scoreUtilisateur = 0
let scoreOrdinateur = 0
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
    zoneResultat.style.display = "none"
    wrapper.style.display = "flex"
    zoneScore.style.display = "flex"
    scoreUtilisateur = 0
    scoreOrdinateur = 0
    zoneScoreUtilisateur.innerText = scoreUtilisateur
    zoneScoreOrdinateur.innerText = scoreOrdinateur
})


const nouvellePartie = () => {
    
    let saisieOrdinateur = Math.ceil(Math.random() * 3)

    zoneCombat.style.display = "flex"

    if(saisieUtilisateur === 1) {
        imgUtilisateur.src = "assets/img/pierre.png"
    }
    else if(saisieUtilisateur === 2) {
        imgUtilisateur.src = "assets/img/papier.png"
    }
    else if(saisieUtilisateur === 3) {
        imgUtilisateur.src = "assets/img/ciseaux.png"
    }
    if(saisieOrdinateur === 1) {
        imgOrdinateur.src = "assets/img/pierre.png"
    }
    else if(saisieOrdinateur === 2) {
        imgOrdinateur.src = "assets/img/papier.png"
    }
    else if(saisieOrdinateur === 3) {
        imgOrdinateur.src = "assets/img/ciseaux.png"
    }

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

    saisieUtilisateur = 0
    saisieOrdinateur = 0

    if(scoreUtilisateur === 3 || scoreOrdinateur === 3) {
        wrapper.style.display = "none"
        zoneScore.style.display = "none"
        zoneResultat.style.display = "block"

        affichageGagnant.innerText = scoreUtilisateur === 3 ? "Vous avez gagné !" : "Vous avez perdu !"

        zoneResultat.appendChild(affichageGagnant)
        zoneCombat.style.display = "none"
        btnCommencer.style.display = "block"
    }
}
