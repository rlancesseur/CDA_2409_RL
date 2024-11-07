let calculer = document.querySelector("button")
let zoneDateNaissance = document.querySelector("#zoneDateNaissance")
let zoneNbAnnee = document.querySelector("#zoneNbAnnee")
let zoneAstro = document.querySelector("#zoneAstro")

function affichage() {
    let dateHeures = document.querySelector("#date").value
    let date = dateHeures.split("T")

    let dateNaissance = new Date(document.querySelector("#date").value)
    let dateAujourdhui = new Date()

    let jour = dateNaissance.getDate()
    let mois = dateNaissance.getMonth()

    let dateFr = jour + "/" + mois + "/" + dateNaissance.getFullYear()

    let intervalle = dateAujourdhui.getFullYear() - dateNaissance.getFullYear()

    let signeAstro = ""

    if (dateNaissance < dateAujourdhui) {
        zoneDateNaissance.innerText = "Vous êtes né le " + dateFr + " à " + date[1]
        zoneNbAnnee.innerText = "Il s'est écoulé " + intervalle + " années depuis votre naissance."
        
        switch (dateNaissance) {
            case jour >= 20 && mois === 1 || jour <= 18 && mois === 2:
                signeAstro = "Verseau"
                break;
            case jour >= 19 && mois === 2 || jour <= 21 && mois === 3:
                signeAstro = "Poissons"
                break;
            case jour >= 20 && mois === 3 || jour <= 19 && mois === 4:
                signeAstro = "Bélier"
                break
            case jour >= 20 && mois === 4 || jour <= 20 && mois === 5:
                signeAstro = "Taureau"
                break
            case jour >= 21 && mois === 5 || jour <= 20 && mois === 6:
                signeAstro = "Gémeaux"
                break
            case jour >= 21 && mois === 6 || jour <= 22 && mois === 7:
                signeAstro = "Cancer"
                break
            case jour >= 23 && mois === 7 || jour <= 22 && mois === 8:
                signeAstro = "Lion"
                break
            case jour >= 23 && mois === 8 || jour <= 22 && mois === 9:
                signeAstro = "Vierge"
                break
            case jour >= 23 && mois === 9 || jour <= 22 && mois === 10:
                signeAstro = "Balance"
                break
            case jour >= 23 && mois === 10 || jour <= 21 && mois === 11:
                signeAstro = "Scorpion"
                break
            case jour >= 22 && mois === 11 || jour <= 21 && mois === 12:
                signeAstro = "Sagittaire"
                break
            case jour >= 22 && mois === 12 || jour <= 19 && mois === 1:
                signeAstro = "Capricorne"
                break

            default:
                signeAstro = "Erreur"
        }

        zoneAstro.innerText = "Votre signe astrologique : " + signeAstro
    }
    
    else {
        zoneDateNaissance.innerText = "Sélectionnez une date dans le passé."
    }
}

calculer.addEventListener("click", affichage); 
