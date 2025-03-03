let nomUtilisateur = document.querySelector("#nomUtilisateur")
let prenomUtilisateur = document.querySelector("#prenomUtilisateur")
let jourNaissance = document.querySelector("#jourNaissance")
let moisNaissance = document.querySelector("#moisNaissance")
let anneeNaissance = document.querySelector("#anneeNaissance")
let inputPseudo = document.querySelector("#inputPseudo")
const btnValider = document.querySelector("#btnValider")
const btnAnnuler = document.querySelector("#btnAnnuler")


const ajouterJours = () => {
  for(let i = 1; i < 31; i++){
    const option = document.createElement("option")
    option.value = i
    option.text = i
    jourNaissance.appendChild(option)
  }
}

const ajouterAnnee = () => {
  for(let i = 1925; i < 2000; i++){
    const option = document.createElement("option")
    option.value = i
    option.text = i
    anneeNaissance.appendChild(option)
  }
}

ajouterJours()
ajouterAnnee()

const valNum = (saisieUtilisateur) => {
    const alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    saisieUtilisateur = saisieUtilisateur.toUpperCase()
    const pseudoUtilisateur = saisieUtilisateur.split("")
    let result = 0

    for(let i = 0; i < pseudoUtilisateur.length; i++) {
      let valLettre = 0
        for(let j = 0; j < alphabet.length; j++) {
            if(pseudoUtilisateur[i] === alphabet[j]) {
                valLettre = j + 1
            }
        }
        result += valLettre
    }
    return result
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
    return signeAstro
}

const formOk = () => {
    let result = false
    if(nomUtilisateur.value !== "" && prenomUtilisateur.value !== "" && jourNaissance.value !== "" &&
      moisNaissance.value !== "" && anneeNaissance.value !== "") {
        result = true
    }
    return result
}

const calculerPseudo = () => {
  if(formOk()){
    let signeAstro = calculerSigneAstro(parseInt(jourNaissance.value), parseInt(moisNaissance.value))
    let valnumPrenom = valNum(prenomUtilisateur.value)
    let valnumNom = valNum(nomUtilisateur.value)
    let valnumResult = valnumPrenom + valnumNom
    let result = signeAstro + valnumResult
    inputPseudo.value = result
    btnValider.disabled = false
  }
  else {
    btnValider.disabled = true
  }
}

const nbJoursAnniv = () => {
  let currentDate = new Date()
  let dateUtilisateur = new Date(currentDate.getFullYear(), moisNaissance.value - 1, jourNaissance.value)
  let intervalles = 0
  if(currentDate.getMonth() < moisNaissance.value) {
    intervalles = dateUtilisateur - currentDate
  }
  else {
    dateUtilisateur = new Date(currentDate.getFullYear() + 1, moisNaissance.value - 1, jourNaissance.value)
    intervalles = dateUtilisateur - currentDate
  }
  
  return Math.round(intervalles / 1000 / 60 / 60 / 24)
}


nomUtilisateur.addEventListener("input", calculerPseudo)
prenomUtilisateur.addEventListener("input", calculerPseudo)
jourNaissance.addEventListener("change", calculerPseudo)
moisNaissance.addEventListener("change", calculerPseudo)
anneeNaissance.addEventListener("change", calculerPseudo)


const setCookie = (cname, cvalue, exdays) => {
  const d = new Date()
  d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000))
  let expires = "expires=" + d.toUTCString()
  
  document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/"
}

btnValider.addEventListener("click", (e) => {
  e.preventDefault()

  let jour = jourNaissance.value < 10 ? "0" + jourNaissance.value : jourNaissance.value
  let mois = moisNaissance.value < 10 ? "0" + moisNaissance.value : moisNaissance.value
  const dateNaissance = jour + "/" + mois + "/" + anneeNaissance.value
  let intervalles = nbJoursAnniv()

  setCookie("firstName", prenomUtilisateur.value, 7)
  setCookie("lastName", nomUtilisateur.value, 7)
  setCookie("date", dateNaissance, 7)
  setCookie("pseudo", inputPseudo.value, 7)
  setCookie("intervalles", intervalles, 7)

  window.location.href = "accueil.html"
})

btnAnnuler.addEventListener("click", () => {
  zoneTexteLibre.value = ""
  nomUtilisateur.value = ""
  prenomUtilisateur.value = ""
  jourNaissance.value = ""
  moisNaissance.value = ""
  anneeNaissance.value = ""
})
