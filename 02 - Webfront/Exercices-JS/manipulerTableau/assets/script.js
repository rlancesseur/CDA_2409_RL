const people = ["Mike Dev", "John Makenzie", "Léa Grande"];

const btnAjouter = document.querySelector("#btnAjouter")
const ul = document.querySelector("ul")
const tbody = document.querySelector("tbody")

const afficherListeTableau = () => {
for(let i = 0; i < people.length; i++) {
    const li = document.createElement("li")
    li.innerText = people[i]
    ul.appendChild(li)
    const tr = document.createElement("tr")
    const tdLastName = document.createElement("td")
    const tdFirstName = document.createElement("td")
    const tdEmail = document.createElement("td")
    const tdSuppr = document.createElement("button")
    const nameSplit = people[i].split(" ")
    tdLastName.innerText = nameSplit[1]
    tdFirstName.innerText = nameSplit[0]
    tdEmail.innerText = nameSplit[0].toLowerCase() + "." + nameSplit[1].toLowerCase() + "@example.com"
    tdSuppr.innerText = "X"
    tdSuppr.classList.add("btnSuppr")
    tdSuppr.style.textAlign = "center"
    tr.appendChild(tdLastName)
    tr.appendChild(tdFirstName)
    tr.appendChild(tdEmail)
    tr.appendChild(tdSuppr)
    tbody.appendChild(tr)
}}

btnAjouter.addEventListener("click", (event) => {
    event.preventDefault()
    ul.innerText = ""   
    tbody.innerText = ""
    
    const zoneAffichage = document.querySelector("#zoneAffichage")
    let prenom = document.querySelector("#prenom").value
    let nom = document.querySelector("#nom").value

    let personneExistante = false
    for(let i = 0; i < people.length; i++){
        if(people[i] == prenom + " " + nom) {
            personneExistante = true
        }
    }

    if(!personneExistante && prenom.length >= 2 && nom.length >= 2) {
        people.push(prenom + " " + nom)
        zoneAffichage.innerText = prenom + " " + nom + " ajouté !"
    }
    afficherListeTableau()
})

afficherListeTableau()
