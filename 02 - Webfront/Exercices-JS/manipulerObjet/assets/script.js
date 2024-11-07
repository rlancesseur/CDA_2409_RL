const myEmployee = {
    lastname: "Doe",
    firstname: "John",
    birthday: "1981-11-12",
    salary: 2150
}

let nom = myEmployee.lastname
let prenom = myEmployee.firstname
let date = myEmployee.birthday
let salaire = myEmployee.salary

let zoneNom = document.querySelector("#nom")
let zonePrenom = document.querySelector("#prenom")
let zoneDate = document.querySelector("#date")
let zoneEmail = document.querySelector("#email")
let zoneSalaire = document.querySelector("#salaire")

zoneNom.innerHTML = nom
zonePrenom.innerHTML = prenom
zoneDate.innerHTML = date
zoneEmail.innerHTML = prenom.toLowerCase() + "." + nom.toLowerCase() + "@" + "example.com"
zoneSalaire.innerHTML = salaire + " €"

let inputPrenom = document.querySelector("#inputPrenom")
let inputNom = document.querySelector("#inputNom")
let inputDate = document.querySelector("#inputDate")
let inputSalaire = document.querySelector("#inputSalaire")
let btnEnregistrer = document.querySelector("#btnEnregistrer")
