const calculer = document.querySelector("button")
const zoneDateNaissance = document.querySelector("#zoneDateNaissance")
const zoneNbAnnee = document.querySelector("#zoneNbAnnee")
const zoneAstro = document.querySelector("#zoneAstro")

function affichage() {
    const dateHeures = document.querySelector("#date").value
    const date = dateHeures.split("T")

    const dateNaissance = new Date(document.querySelector("#date").value)
    const dateAujourdhui = new Date()

    const jour = dateNaissance.getDate()
    const mois = dateNaissance.getMonth()+1
    const annee = dateNaissance.getFullYear()

    let dateFr = jour + "/" + mois + "/" + annee

    let intervalle = dateAujourdhui.getFullYear() - annee

    let signeAstro = ""

    if (dateNaissance < dateAujourdhui) {
        zoneDateNaissance.innerText = "Vous êtes né le " + dateFr + " à " + date[1]
        zoneNbAnnee.innerText = "Il s'est écoulé " + intervalle + " années depuis votre naissance."
        
        switch (dateNaissance) {
            case jour >= 20 && mois === 1 || jour <= 18 && mois === 2:
                signeAstro = "Verseau"
                break
            case jour >= 19 && mois === 2 || jour <= 20 && mois === 3:
                signeAstro = "Poissons"
                break
            case jour >= 21 && mois === 3 || jour <= 19 && mois === 4:
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
            case jour >= 22 && mois === 12 || jour <= 20 && mois === 1:
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
