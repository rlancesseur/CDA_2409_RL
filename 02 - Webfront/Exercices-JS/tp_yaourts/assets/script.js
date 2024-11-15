const affichageCouleurs = document.querySelector("#affichageCouleurs")
const couleursPreferees = document.querySelector("#couleursPreferees")
const vert = document.querySelector("#vert")
const rouge = document.querySelector("#rouge")
const jaune = document.querySelector("#jaune")
const bleu = document.querySelector("#bleu")
const orange = document.querySelector("#orange")
const btnRandom = document.querySelector("#btnRandom")

 const afficherCouleurs = () => {
    affichageCouleurs.style.display = "flex"
    fetch("https://api.devoldere.net/polls/yoghurts/")
    .then(response => response.json())
    .then(couleurs => {
        let nbrGreen = 0
        let nbrRed = 0
        let nbrYellow = 0
        let nbrBlue = 0
        let nbrOrange = 0
        for(let couleur of couleurs.results) {
            
            if(couleur === "green") {
                nbrGreen++
            }
            if(couleur === "red") {
                nbrRed++
            }
            if(couleur === "yellow") {
                nbrYellow++
            }
            if(couleur === "blue") {
                nbrBlue++
            }
            if(couleur === "orange") {
                nbrOrange++
            }
        }

        vert.innerText = nbrGreen
        rouge.innerText = nbrRed
        jaune.innerText = nbrYellow
        bleu.innerText = nbrBlue
        orange.innerText = nbrOrange

        const tableauCouleurs = [nbrGreen, nbrRed, nbrYellow, nbrBlue, nbrOrange]
        tableauCouleurs.sort().reverse()

        // IF/ELSE IF DE LA HONTE, mais en attendant de trouver une meilleure solution =>
        let positionUne = ""
        let positionDeux = ""
        if(tableauCouleurs[0] === nbrGreen) {
            positionUne = "Verte"
        }
        else if(tableauCouleurs[0] === nbrRed) {
            positionUne = "Rouge"
        }
        else if(tableauCouleurs[0] === nbrYellow) {
            positionUne = "Jaune"
        }
        else if(tableauCouleurs[0] === nbrBlue) {
            positionUne = "Bleu"
        }
        else if(tableauCouleurs[0] === nbrOrange) {
            positionUne = "Orange"
        }
        if(tableauCouleurs[1] === nbrGreen) {
            positionDeux = "Verte"
        }
        else if(tableauCouleurs[1] === nbrRed) {
            positionDeux = "Rouge"
        }
        else if(tableauCouleurs[1] === nbrYellow) {
            positionDeux = "Jaune"
        }
        else if(tableauCouleurs[1] === nbrBlue) {
            positionDeux = "Bleu"
        }
        else if(tableauCouleurs[1] === nbrOrange) {
            positionDeux = "Orange"
        }

        couleursPreferees.innerText = positionUne + " et " + positionDeux

    })
}

afficherCouleurs()
btnRandom.addEventListener("click", afficherCouleurs)
