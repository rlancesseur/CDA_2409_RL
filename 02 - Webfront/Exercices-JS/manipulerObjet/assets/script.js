let zoneNomH1 = document.querySelector("#h1Nom")
let zonePrenomH1 = document.querySelector("#h1Prenom")
let zoneNom = document.querySelector("#nom")
let zonePrenom = document.querySelector("#prenom")
let zoneDate = document.querySelector("#date")
let zoneEmail = document.querySelector("#email")
let zoneSalaire = document.querySelector("#salaire")

zoneNomH1.innerHTML = myEmployee.lastname
zonePrenomH1.innerHTML = myEmployee.firstname
zoneNom.innerHTML = myEmployee.lastname
zonePrenom.innerHTML = myEmployee.firstname
zoneDate.innerHTML = myEmployee.birthday
zoneEmail.innerHTML = myEmployee.lastname.toLowerCase() + "." + myEmployee.firstname.toLowerCase() + "@" + "example.com"
zoneSalaire.innerHTML = myEmployee.salary + " €"

let inputPrenom = document.querySelector("#inputPrenom")
let inputNom = document.querySelector("#inputNom")
let inputDate = document.querySelector("#inputDate")
let inputSalaire = document.querySelector("#inputSalaire")
let btnEnregistrer = document.querySelector("#btnEnregistrer")

let dateUtilisateur = new Date(inputDate.value)
let dateActu = new Date()

inputPrenom.placeholder = myEmployee.firstname
inputNom.placeholder = myEmployee.lastname
inputDate.placeholder = myEmployee.birthday
inputSalaire.placeholder = myEmployee.salary

const form = document.querySelector('form')

form.addEventListener("submit", (event) => {
    // On empêche le comportement par défaut
    event.preventDefault()
    
    if(inputPrenom.value.length >= 2) {
        myEmployee.firstname = inputPrenom.value
        zonePrenomH1.innerHTML = myEmployee.firstname
        zonePrenom.innerHTML = myEmployee.firstname
        zoneEmail.innerHTML = myEmployee.lastname.toLowerCase() + "." + myEmployee.firstname.toLowerCase() + "@" + "example.com"
    }

    if (inputNom.value.length >= 2) {
        myEmployee.lastname = inputNom.value
        zoneNomH1.innerHTML = myEmployee.lastname
        zoneNom.innerHTML = myEmployee.lastname
        zoneEmail.innerHTML = myEmployee.lastname.toLowerCase() + "." + myEmployee.firstname.toLowerCase() + "@" + "example.com"
    }

    if(dateUtilisateur.getTime() < dateActu.getTime()) {
        myEmployee.birthday = inputDate.value
        zoneDate.innerHTML = myEmployee.birthday
    }

    if(inputSalaire.value > myEmployee.salary) {
        myEmployee.salary = inputSalaire.value
        zoneSalaire.innerHTML = myEmployee.salary + " €"
    }
})

