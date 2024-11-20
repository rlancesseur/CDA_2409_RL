const btnCommencer = document.querySelector("#btnCommencer")
const wrapper = document.querySelector("#wrapper")
const zoneScore = document.querySelector("#zoneScore")
const zoneResultat = document.querySelector("#zoneResultat")
const imgPierre = document.querySelector("#imgPierre")
const imgPapier = document.querySelector("#imgPapier")
const imgCiseaux = document.querySelector("#imgCiseaux")

btnCommencer.addEventListener("click", () => {
    btnCommencer.style.display = "none"
    wrapper.style.display = "flex"
    zoneScore.style.display = "flex"
})

const nouvellePartie = () => {
    let zoneScoreUtilisateur = document.querySelector("#zoneScoreUtilisateur")
    let zoneScoreOrdinateur = document.querySelector("#zoneScoreOrdinateur")
    let scoreUtilisateur = 0
    let scoreOrdinateur = 0

    while(scoreUtilisateur < 3 && scoreOrdinateur < 3) {

        let saisieUtilisateur = 0
        let saisieOrdinateur = 0
        
        imgPierre.addEventListener("click", () => {
            saisieUtilisateur = 1
        })
        imgPapier.addEventListener("click", () => {
            saisieUtilisateur = 2
        })
        imgCiseaux.addEventListener("click", () => {
            saisieUtilisateur = 3
        })

        saisieOrdinateur = Math.ceil(Math.random() * 3)

        if(saisieUtilisateur === 1 && saisieOrdinateur === 2) {
            scoreOrdinateur++
        }
            else if (saisieUtilisateur === 1 && saisieOrdinateur === 3) {
                scoreUtilisateur++
            }
            else if (saisieUtilisateur === 2 && saisieOrdinateur === 1) {
                scoreUtilisateur++
            }
            else if (saisieUtilisateur === 2 && saisieOrdinateur === 3) {
                scoreOrdinateur++
            }
            else if (saisieUtilisateur === 3 && saisieOrdinateur === 1) {
                scoreOrdinateur++
            }
            else if (saisieUtilisateur === 3 && saisieOrdinateur === 2) {
                scoreUtilisateur++
            }

            zoneScoreUtilisateur.innerText = scoreUtilisateur
            zoneScoreOrdinateur.innerText = scoreOrdinateur
    }

    wrapper.style.display = "none"
    zoneScore.style.display = "none"
    zoneResultat.style.display = "block"
    let winner = document.createElement("p")

    if(scoreUtilisateur === 3) {
        winner.innerText = "Vous avez gagné !"
    }
    else if(scoreOrdinateur === 3) {
        winner.innerText = "Vous avez perdu !"
    }
    zoneResultat.appendChild(winner)

    btnCommencer.style.display = "block"

}

