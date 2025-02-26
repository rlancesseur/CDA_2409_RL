let zoneTexteLibre = document.querySelector("#zoneTexteLibre")
let nomUtilisateur = document.querySelector("#nomUtilisateur").value
let prenomUtilisateur = document.querySelector("#prenomUtilisateur").value
let jourNaissance = document.querySelector("#jourNaissance")
let moisNaissance = document.querySelector("#moisNaissance")
let anneeNaissance = document.querySelector("#anneeNaissance")
let inputPseudo = document.querySelector("#inputPseudo")
const btnValider = document.querySelector("#btnValider")
const btnAnnuler = document.querySelector("#btnAnnuler")

const alphabetString = "abcdefghijklmnopqrstuvwxyz"

const valNum = (prenomUtilisateur, nomUtilisateur) => {
    const alphabetArray = alphabetString.split("")
    const pseudoUtilisateur = prenomUtilisateur.toUpperCase() + nomUtilisateur.toUpperCase()
    pseudoUtilisateur.split("")
    let valLettre = 0
    let result = 0

    for(let i = 0; i < pseudoUtilisateur.length; i++) {
        for(let j = 0; j < alphabetArray; j++) {
            if(pseudoUtilisateur[i] == alphabetArray[j]) {
                valLettre = j+1
            }
        }
        result += valLettre
    }
}

const calculerSigneAstro = (jour, mois) => {
    let signeAstro = ""

    if ((jour >= 20 && mois === 1) || (jour <= 18 && mois === 2)) {
        signeAstro = "Verseau";
      } 
      else if ((jour >= 19 && mois === 2) || (jour <= 20 && mois === 3)) {
        signeAstro = "Poissons";
      }
      else if ((jour >= 21 && mois === 3) || (jour <= 19 && mois === 4)) {
        signeAstro = "Bélier"
      }
      else if ((jour >= 20 && mois === 4) || (jour <= 20 && mois === 5)) {
        signeAstro = "Taureau"
      }
      else if ((jour >= 21 && mois === 5) || (jour <= 20 && mois === 6)) {
        signeAstro = "Gémeaux"
      }
      else if ((jour >= 21 && mois === 6) || (jour <= 22 && mois === 7)) {
        signeAstro = "Cancer"
      }
      else if ((jour >= 23 && mois === 7 ) || (jour <= 22 && mois === 8)) {
        signeAstro = "Lion"
      }
      else if ((jour >= 23 && mois === 8) || (jour <= 22 && mois === 9)) {
        signeAstro = "Vierge"
      }
      else if ((jour >= 23 && mois === 9) || (jour <= 22 && mois === 10)) {
        signeAstro = "Balance"
      }
      else if ((jour >= 23 && mois === 10) || (jour <= 21 && mois === 11)) {
        signeAstro = "Scorpion"
      }
      else if ((jour >= 22 && mois === 11 ) || (jour <= 21 && mois === 12)) {
        signeAstro = "Sagittaire"
      }
      else if ((jour >= 22 && mois === 12) || (jour <= 20 && mois === 1)) {
        signeAstro = "Capricorne"
      }
      else {
        signeAstro = "Erreur"
    }
}

const formok = () => {
    let result = false
    if(nomUtilisateur !== "" && prenomUtilisateur !== "" && jourNaissance.value ) {
        result = true
    }
}

const calculerPseudo = () => {
    let result = 
}
