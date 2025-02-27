const btnValider = document.querySelector("#btnValider")
const login = document.querySelector("#login")
const menu = document.querySelector("#menu")
const zoneName = document.querySelector("#name")
let inputName = zoneName.value
const username = document.querySelector("#username")
const btnCommencer = document.querySelector("#btnCommencer")
const zoneResultat = document.querySelector("#zoneResultat")
const enJeu = document.querySelector("#enJeu")
const zoneCombat = document.querySelector("#zoneCombat")
const wrapper = document.querySelector("#wrapper")
const zoneScore = document.querySelector("#zoneScore")
let imgUtilisateur = document.querySelector("#imgUtilisateur")
let imgOrdinateur = document.querySelector("#imgOrdinateur")
const zoneScoreUtilisateur = document.querySelector("#zoneScoreUtilisateur")
const zoneScoreOrdinateur = document.querySelector("#zoneScoreOrdinateur")
const imgPierre = document.querySelector("#imgPierre")
const imgPapier = document.querySelector("#imgPapier")
const imgCiseaux = document.querySelector("#imgCiseaux")
const nbrJouee = document.querySelector("#nbrJouee")
const nbrGagnee = document.querySelector("#nbrGagnee")
const nbrPerdue = document.querySelector("#nbrPerdue")
let affichageGagnant = document.createElement("p")
let scoreUtilisateur = 0
let scoreOrdinateur = 0
let saisieUtilisateur = 0

let nomEnregistre = localStorage.getItem("username")
let partieJouee = parseInt(localStorage.getItem("partieJouee")) || 0
let partieGagnee = parseInt(localStorage.getItem("partieGagnee")) || 0
let partiePerdue = parseInt(localStorage.getItem("partiePerdue")) || 0

if (nomEnregistre !== null) {
    login.style.display = "none"
    menu.style.display = "flex"
    username.innerText = nomEnregistre
    nbrJouee.innerText = partieJouee
    nbrGagnee.innerText = partieGagnee
    nbrPerdue.innerText = partiePerdue
}

zoneName.addEventListener('input', () => {
    inputName = zoneName.value
    username.innerText = inputName
})

btnValider.addEventListener("click", () => {
    if(inputName === "") {
        alert("Veuillez entrer un nom")
    }
    else {
        localStorage.setItem("username", inputName)
        login.style.display = "none"
        menu.style.display = "flex"
        nbrJouee.innerText = partieJouee
        nbrGagnee.innerText = partieGagnee
        nbrPerdue.innerText = partiePerdue
    } 
})

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
    enJeu.style.display = "flex"
    menu.style.display = "none"
    wrapper.style.display = "flex"
    zoneScore.style.display = "flex"
    zoneCombat.style.display = "flex"
    scoreUtilisateur = 0
    scoreOrdinateur = 0
    zoneScoreUtilisateur.innerText = scoreUtilisateur
    zoneScoreOrdinateur.innerText = scoreOrdinateur
    imgUtilisateur.src = "assets/img/videYou.png"
    imgOrdinateur.src = "assets/img/videComputer.png"
    localStorage.setItem("partieJouee", partieJouee)
    localStorage.setItem("partieGagnee", partieGagnee)
    localStorage.setItem("partiePerdue", partiePerdue)
    partieJouee++
    nbrJouee.innerText = partieJouee
})


const nouvellePartie = () => {
    
    let saisieOrdinateur = Math.ceil(Math.random() * 3)

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

        if(scoreUtilisateur === 3) {
            affichageGagnant.innerText = "Vous avez gagné !"
            partieGagnee++
        }
        else if(scoreOrdinateur === 3) {
            affichageGagnant.innerText = "Vous avez perdu !"
            partiePerdue++
        }

        wrapper.style.display = "none"

        setTimeout(() => {
            zoneResultat.appendChild(affichageGagnant)
            enJeu.style.display = "none"
            menu.style.display = "flex"
            zoneName.style.display = "none"
            nbrJouee.innerText = partieJouee
            nbrGagnee.innerText = partieGagnee
            nbrPerdue.innerText = partiePerdue
        }, 1500)  
    }
}
