let people = ['Mike Dev', 'John Makenzie', 'Léa Grande']

const inputPrenom = document.querySelector("#inputPrenom")
const inputNom = document.querySelector("#inputNom")
const btnAjouter = document.querySelector("#btnAjouter")
const zoneAffichage = document.querySelector("#zoneAffichage")
const ul = document.querySelector("ul")
const tbody = document.querySelector("tbody")

const AffichageListe = () => {
    for(let i = 0; i < people.length; i++) {
        const li = document.createElement("li")
        li.innerText = people[i]
        ul.appendChild(li)
    }    
}

const AffichageTableau = () => {
    for(let i = 0; i < people.length; i++) {
        const personSplit = people[i].split(" ")
        const tr = document.createElement("tr")
        const tdNom = document.createElement("td")
        tdNom.innerText = personSplit[1]
        const tdPrenom = document.createElement("td")
        tdPrenom.innerText = personSplit[0]
        const tdEmail = document.createElement("td")
        tdEmail.innerText = personSplit[1].toLowerCase() + "." + personSplit[0].toLowerCase() + "@example.com"
        const btnSuppr = document.createElement("button")
        btnSuppr.innerText = "X"

        tr.appendChild(tdNom)
        tr.appendChild(tdPrenom)
        tr.appendChild(tdEmail)
        tr.appendChild(btnSuppr)
        tbody.appendChild(tr)
    }   
}

btnAjouter.addEventListener("click", (e) => {
    e.preventDefault()
    ul.innerText = ""
    tbody.innerText = ""

    let personneExistante = false
    for(let i = 0; i < people.length; i++){
        if(people[i] == inputPrenom.value + " " + inputNom.value) {
            personneExistante = true
        }
    }

    if(inputPrenom.value.length > 1 && inputNom.value.length > 1 && !personneExistante) {
        const nouvellePersonne = inputPrenom.value + " " + inputNom.value
        people.push(nouvellePersonne)
        zoneAffichage.innerText = inputPrenom.value + " " + inputNom.value + " ajouté !"
    }

    AffichageListe()
    AffichageTableau()
})


AffichageListe()
AffichageTableau()
