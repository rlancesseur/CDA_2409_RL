import { Pays } from './Pays.js'

const btnValider = document.querySelector("#validate")
const inputCodePays = document.querySelector("#codePays")
const inputNomPays = document.querySelector("#nomPays")
const divResult = document.querySelector("#result")

document.querySelector("#titre").textContent = "Ajouter un pays"

btnValider.addEventListener("click", (e) => {
    e.preventDefault()
    divResult.textContent = ""
    let codePays = inputCodePays.value
    let nomPays = inputNomPays.value

    try {
        let monPays = new Pays(codePays, nomPays)

    } catch(error) {
        divResult.textContent = error
    }
})