let valider = document.querySelector("#valider")
let vider = document.querySelector("#vider")
let text = document.querySelector("#text")
let textAge = document.querySelector("#textAge")
let textRetraite = document.querySelector("#textRetraite")
let ageRetraite = 0

function afficher() {
    let name = document.querySelector("#name").value
    let age = document.querySelector("#age").value

        if(name !== "" && age > 0) {
            text.innerHTML = "Bonjour " + name + ", votre âge est : " + age + "."
            if(age >= 18) {
                textAge.innerHTML = "Vous êtes majeur."

                if(age < 64) {
                    ageRetraite = 64 - age
                    textRetraite.innerHTML = "Il vous reste " + ageRetraite + " année(s) avant la retraite"
                }
                else if(age > 64) {
                    ageRetraite = age - 64
                    textRetraite.innerHTML = "Vous êtes à la retraite depuis " + ageRetraite + " année(s)"
                }
                else {
                    textRetraite.innerHTML = "Vous prenez votre retraite cette année !"
                }
            }
            else {
                textAge.innerHTML = "Vous êtes mineure."
            }
        }
        else {
            text.innerHTML = "Compléter/corriger le formulaire."
        }
}

valider.addEventListener("click", afficher);

