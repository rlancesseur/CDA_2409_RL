let calculer = document.querySelector("button")
let zoneDateNaissance = document.querySelector("#zoneDateNaissance")
let zoneNbAnnee = document.querySelector("#zoneNbAnnee")
let zoneAstro = document.querySelector("#zoneAstro")

function affichage() {
    let dateHeures = document.querySelector("#date").value
    let date = dateHeures.split("T")

    let dateNaissance = new Date(document.querySelector("#date").value)
    let dateAujourdhui = new Date()

    let dateFr = dateNaissance.getDate() + "/" + dateNaissance.getMonth() + "/" + dateNaissance.getFullYear()

    let intervalle = dateAujourdhui.getFullYear() - dateNaissance.getFullYear()

    let signeAstro = ""

    if (dateNaissance < dateAujourdhui) {
        zoneDateNaissance.innerText = "Vous êtes né le " + dateFr + " à " + date[1]
        zoneNbAnnee.innerText = "Il s'est écoulé " + intervalle + " années depuis votre naissance."
        
        // if() {
        //     signeAstro = "Capricorne"
        // }
        // else if() {
        //     signeAstro = "Sagittaire"
        // }
        // else if() {
        //     signeAstro = "Scorption"
        // }
        // else if() {
        //     signeAstro = "Balance"
        // }
        // else if() {
        //     signeAstro = "Vierge"
        // }
        // else if() {
        //     signeAstro = "Lion"
        // }
        // else if() {
        //     signeAstro = "Cancer"
        // }
        // else if() {
        //     signeAstro = "Gémeaux"
        // }
        // else if() {
        //     signeAstro = "Taureau"
        // }
        // else if() {
        //     signeAstro = "Bélier"
        // }
        // else if() {
        //     signeAstro = "Poissons"
        // }
        // else if() {
        //     signeAstro = "Verseau"
        // }


        // zoneAstro.innerText = "Votre signe astrologique : " + signeAstro
    }
    else {
        zoneDateNaissance.innerText = "Sélectionnez une date dans le passé."
    }
}

calculer.addEventListener("click", affichage); 


