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

inputPrenom.placeholder = myEmployee.firstname
inputNom.placeholder = myEmployee.lastname
inputDate.placeholder = myEmployee.birthday
inputSalaire.placeholder = myEmployee.salary

function maj() {
    if(myEmployee.firstname.length >= 2 && myEmployee.lastname >= 2) {
        myEmployee.firstname = inputPrenom.value
        myEmployee.lastname = inputNom.value
    }

    if(inputDate.value < Date.now) {
        myEmployee.birthday = inputDate.value
    }

    if(inputSalaire.value > myEmployee.salary) {
        myEmployee.salary = inputSalaire.value
    }
}

btnEnregistrer.addEventListener("click", maj)
