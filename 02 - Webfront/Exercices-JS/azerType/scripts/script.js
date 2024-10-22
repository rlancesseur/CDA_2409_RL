function lancerBoucleJeu(listMots) {
    let score = 0
    for(let i = 0; i < listMots.length; i++) {
        let saisieUtilisateur = prompt("Saisir le mot : ")
        if(saisieUtilisateur === listMots[i]) {
            score++
        }
    }
    console.log("Votre score est de " + score + " sur " + listMots.length)
}
