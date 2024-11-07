const people = ["Mike Dev", "John Makenzie", "Léa Grande"];

let liUn = document.querySelector("#un")
let liDeux = document.querySelector("#deux")
let liTrois = document.querySelector("#trois")

let un = people[0]
let deux = people[1]
let trois = people[2]

liUn.innerHTML = un
liDeux.innerHTML = deux
liTrois.innerHTML = trois

let tdNomUn = document.querySelector("#tdNomUn")
let tdPrenomUn = document.querySelector("#tdPrenomUn")
let tdEmailUn = document.querySelector("#tdEmailUn")
let tdNomDeux = document.querySelector("#tdNomDeux")
let tdPrenomDeux = document.querySelector("#tdPrenomDeux")
let tdEmailDeux = document.querySelector("#tdEmailDeux")
let tdNomTrois = document.querySelector("#tdNomTrois")
let tdPrenomTrois = document.querySelector("#tdPrenomTrois")
let tdEmailTrois = document.querySelector("#tdEmailTrois")

let splitUn = un.split(" ")
let splitDeux = deux.split(" ")
let splitTrois = trois.split(" ")

tdNomUn.innerHTML = splitUn[1]
tdPrenomUn.innerHTML = splitUn[0]
tdEmailUn.innerHTML = splitUn[0].toLowerCase() + "." + splitUn[1].toLowerCase() + "@" + "example.com"
tdNomDeux.innerHTML = splitDeux[1]
tdPrenomDeux.innerHTML = splitDeux[0]
tdEmailDeux.innerHTML = splitDeux[0].toLowerCase() + "." + splitDeux[1].toLowerCase() + "@" + "example.com"
tdNomTrois.innerHTML = splitTrois[1]
tdPrenomTrois.innerHTML = splitTrois[0]
tdEmailTrois.innerHTML = splitTrois[0].toLowerCase() + "." + splitTrois[1].toLowerCase() + "@" + "example.com"


let supprUn = document.querySelector("#supprUn")
let supprDeux = document.querySelector("#supprDeux")
let supprTrois = document.querySelector("#supprTrois")

let trUn = document.querySelector("#trUn")
let trDeux = document.querySelector("#trDeux")
let trTrois = document.querySelector("#trTrois")

function supprimerUn() {
    people.splice(0)
    liUn.remove()
    trUn.remove()
}

function supprimerDeux() {
    people.splice(1)
    liDeux.remove()
    trDeux.remove()
}

function supprimerTrois() {
    people.splice(2)
    liTrois.remove()
    trTrois.remove()
}

supprUn.addEventListener("click", supprimerUn)
supprDeux.addEventListener("click", supprimerDeux)
supprTrois.addEventListener("click", supprimerTrois)

let prenom = document.querySelector("#prenom")
let nom = document.querySelector("#nom")
let btnAjouter = document.querySelector("#btnAjouter")
let zoneAffichage = document.querySelector("#zoneAffichage")

function ajout() {
    if(prenom.length >= 2 || nom.length >= 2) {
        zoneAffichage.innerHTML = prenom + " " + nom + " ajouté !"
    }
    else {
        zoneAffichage.innerHTML = "Le nom et le prénom doivent contenir plus de deux lettres."
    }
}

btnAjouter.addEventListener("click", ajout)
