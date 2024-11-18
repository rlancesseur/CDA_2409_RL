let scoreJoueurUn = 0
let scoreJoueurDeux = 0
let scoreJoueurTrois = 0
let sommeDes = 0
let j1 = document.querySelector("#j1")
let j2 = document.querySelector("#j2")
let j3 = document.querySelector("#j3")

const lancerJeu = () => {
    fetch("https://api.devoldere.net/polls/dice/")
    .then(response => response.json())
    .then(parties => {
        for(let i = 0; i < parties.results.length; i++) {
            let des1 = 0
            let des2 = 0

            let partie = parties.results[i]
            let partieSplit = partie.split(" ")

            if (partieSplit[0] === 1) {
                sommeDes = 0
                des1 = partieSplit[1]
                des2 = partieSplit[2]
                sommeDes = des1 + des2
                if(sommeDes >= 6 && sommeDes <= 10 && des1 != des2) {
                    scoreJoueurUn += 1
                }
                else if(sommeDes > 10 && des1 != des2) {
                    scoreJoueurUn += 3
                }
                else if(des1 = des2) {
                    scoreJoueurUn -= 2
                }
                j1.innerText = scoreJoueurUn
            }

            if (partieSplit[0] === 2) {
                sommeDes = 0
                des1 = partieSplit[1]
                des2 = partieSplit[2]
                sommeDes = des1 + des2
                if(sommeDes >= 6 && sommeDes <= 10 && des1 != des2) {
                    scoreJoueurDeux += 1
                }
                else if(sommeDes > 10 && des1 != des2) {
                    scoreJoueurDeux += 3
                }
                else if(des1 = des2) {
                    scoreJoueurDeux -= 2
                }
                j2.innerText = scoreJoueurDeux
            }

            if (partieSplit[0] === 3) {
                sommeDes = 0
                des1 = partieSplit[1]
                des2 = partieSplit[2]
                sommeDes = des1 + des2
                if(sommeDes >= 6 && sommeDes <= 10 && des1 != des2) {
                    scoreJoueurTrois += 1
                }
                else if(sommeDes > 10 && des1 != des2) {
                    scoreJoueurTrois += 3
                }
                else if(des1 = des2) {
                    scoreJoueurTrois -= 2
                }
                j3.innerText = scoreJoueurTrois
            }
        }
    })
}

lancerJeu()
