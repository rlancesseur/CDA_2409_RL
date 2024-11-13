const btnValider = document.querySelector("#valider")
const btnVider = document.querySelector("#vider")
const text = document.querySelector("#text")
const textAge = document.querySelector("#textAge")
const textRetraite = document.querySelector("#textRetraite")

function afficher() {
    let name = document.querySelector("#name").value
    let age = document.querySelector("#age").value
    let ageRetraite = 0

        if(name !== "" && age > 0) {
            text.innerText = "Bonjour " + name + ", votre âge est : " + age + "."
            if(age >= 18) {
                textAge.innerText = "Vous êtes majeur."

                if(age < 64) {
                    ageRetraite = 64 - age
                    textRetraite.innerText = "Il vous reste " + ageRetraite + " année(s) avant la retraite."
                }
                else if(age > 64) {
                    ageRetraite = age - 64
                    textRetraite.innerText = "Vous êtes à la retraite depuis " + ageRetraite + " année(s)"
                }
                else {
                    textRetraite.innerText = "Vous prenez votre retraite cette année !"
                }
            }
            else {
                textAge.innerText = "Vous êtes mineure."
            }
        }
        else {
            text.innerText = "Compléter/corriger le formulaire."
        }
}

function vider() {
    text.innerText = ""
    textAge.innerText = ""
    textRetraite.innerText = ""
}

btnValider.addEventListener("click", afficher)
btnVider.addEventListener("click", vider)
