function afficherResultat(score, nbMotsProposes) {
    let spanScore = document.querySelector(".zoneScore span")
    let affichageScore = `${score} / ${nbMotsProposes}` 
    spanScore.innerText = affichageScore
}


function afficherProposition(proposition) {
    let zoneProposition = document.querySelector(".zoneProposition")
    zoneProposition.innerText = proposition
}


function lancerJeu() {
    let score = 0
    let i = 0

    let btnValiderMot = document.getElementById("btnValiderMot")
    let inputEcriture = document.getElementById("inputEcriture")
    afficherProposition(listMots[i])
    btnValiderMot.addEventListener("click", () => {
        console.log(inputEcriture.value)
        if (inputEcriture.value === listeMots[i]) {
            score++
        }
        i++
        afficherResultat(score, i)
        inputEcriture.value = ''
        if (listMots[i] === undefined) {
            afficherProposition("Le jeu est fini")
            btnValiderMot.disabled = true
        } else {
            afficherProposition(listMots[i])
        }
        
        afficherResultat(score, i)
    })

}
