let nomUtilisateur = document.querySelector("#nomUtilisateur")
let prenomUtilisateur = document.querySelector("#prenomUtilisateur")
let jourNaissance = document.querySelector("#jourNaissance")
let moisNaissance = document.querySelector("#moisNaissance")
let anneeNaissance = document.querySelector("#anneeNaissance")
let inputPseudo = document.querySelector("#inputPseudo")
const btnValider = document.querySelector("#btnValider")
const btnAnnuler = document.querySelector("#btnAnnuler")


const ajouterJours = () => {
    for (let i = 1; i < 31; i++) {
        const option = document.createElement("option")
        option.value = i
        option.text = i
        jourNaissance.appendChild(option)
    }
}

const ajouterAnnee = () => {
    for (let i = 1925; i < 2000; i++) {
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

    for (let i = 0; i < pseudoUtilisateur.length; i++) {
        let valLettre = 0
        for (let j = 0; j < alphabet.length; j++) {
            if (pseudoUtilisateur[i] === alphabet[j]) {
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
    else if ((jour >= 23 && mois === 7) || (jour <= 22 && mois === 8)) {
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
    else if ((jour >= 22 && mois === 11) || (jour <= 21 && mois === 12)) {
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
    if (nomUtilisateur.value !== "" && prenomUtilisateur.value !== "" && jourNaissance.value !== "" &&
        moisNaissance.value !== "" && anneeNaissance.value !== "") {
        result = true
    }
    return result
}

const calculerPseudo = () => {
    if (formOk()) {
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
    let dateUtilisateur = new Date(currentDate.getFullYear(), moisNaissance.value, jourNaissance.value)
    let intervalles = 0
    if (currentDate.getMonth() + 1 < moisNaissance.value) {
        intervalles = dateUtilisateur - currentDate
    }
    else {
        dateUtilisateur = new Date(currentDate.getFullYear() + 1, moisNaissance.value, jourNaissance.value)
        intervalles = dateUtilisateur - currentDate
    }

    return Math.round(intervalles / 1000 / 60 / 60 / 24)
}


nomUtilisateur.addEventListener("input", calculerPseudo)
prenomUtilisateur.addEventListener("input", calculerPseudo)
jourNaissance.addEventListener("change", calculerPseudo)
moisNaissance.addEventListener("change", calculerPseudo)
anneeNaissance.addEventListener("change", calculerPseudo)


const setCookie = (cname, cvalue, ex = {}) => {
    if (ex.length === 0) {
        ex = { 'year': 0, 'month': 1, 'day': 1 }
    }

    let dateJour = new Date()
    let year = ex.year != null ? parseInt(dateJour.getFullYear()) + ex.year : dateJour.getFullYear()
    let month = ex.month != null ? parseInt(dateJour.getMonth() + 1) + ex.month : dateJour.getMonth() + 1
    let day = ex.day != null ? parseInt(dateJour.getDate()) + ex.day : dateJour.getDate()

    let dateExpire = new Date(year, month, day)
    let expires = "expires=" + dateExpire.toUTCString()

    document.cookie = cname + "=" + cvalue + ";" + expires + ";"
    console.log(ex);

}

btnValider.addEventListener("click", (e) => {
    e.preventDefault()

    let jour = jourNaissance.value < 10 ? "0" + jourNaissance.value : jourNaissance.value
    let mois = moisNaissance.value < 10 ? "0" + moisNaissance.value : moisNaissance.value
    const dateNaissance = jour + "/" + mois + "/" + anneeNaissance.value
    let intervalles = nbJoursAnniv()

    setCookie("firstName", prenomUtilisateur.value, { 'month': 2, 'day': 1 })
    setCookie("lastName", nomUtilisateur.value, { 'year': 0, 'day': 1 })
    setCookie("date", dateNaissance, { 'year': 1 })
    setCookie("pseudo", inputPseudo.value, { 'day': 1 })
    setCookie("intervalles", intervalles)

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
