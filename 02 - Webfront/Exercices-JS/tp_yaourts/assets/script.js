const couleursPreferees = document.querySelector("#couleursPreferees")
const vert = document.querySelector("#vert")
const rouge = document.querySelector("#rouge")
const jaune = document.querySelector("#jaune")
const bleu = document.querySelector("#bleu")
const orange = document.querySelector("#orange")
const btnRandom = document.querySelector("#btnRandom")

 const afficherCouleurs = () => {
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
        couleursPreferees.innerText = tableauCouleurs[0] + " " + tableauCouleurs[1]

    })
}

btnRandom.addEventListener("click", afficherCouleurs)
