const afficherTableau = () => {
    fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
    .then(response => response.json())
    .then(cartes => {
        for(let carte of cartes) {
            const tbody = document.querySelector("tbody")
            const tr = document.createElement("tr")
            const tdId = document.createElement("td")
            const tdName = document.createElement("td")
            const tdLevel = document.createElement("td")
            const tdDescription = document.createElement("td")
            const tdPower = document.createElement("td")
            const tdAttack = document.createElement("td")
            const tdArmor = document.createElement("td")
            const tdDamage = document.createElement("td")
            const tdMitigation = document.createElement("td")
            const tdPlayed = document.createElement("td")
            const tdVictory = document.createElement("td")
            const tdDefeat = document.createElement("td")
            const tdDraw = document.createElement("td")

            tdId.innerText = carte.id
            tdName.innerText = carte.name
            tdLevel.innerText = carte.level
            tdDescription.innerText = carte.description || ""
            tdPower.innerText = carte.power
            tdAttack.innerText = carte.attack
            tdArmor.innerText = carte.armor
            tdDamage.innerText = carte.damage
            tdMitigation.innerText = carte.mitigation
            tdPlayed.innerText = carte.played
            tdVictory.innerText = carte.victory
            tdDefeat.innerText = carte.defeat
            tdDraw.innerText = carte.draw

            tr.appendChild(tdId)
            tr.appendChild(tdName)
            tr.appendChild(tdLevel)
            tr.appendChild(tdDescription)
            tr.appendChild(tdPower)
            tr.appendChild(tdAttack)
            tr.appendChild(tdArmor)
            tr.appendChild(tdDamage)
            tr.appendChild(tdMitigation)
            tr.appendChild(tdPlayed)
            tr.appendChild(tdVictory)
            tr.appendChild(tdDefeat)
            tr.appendChild(tdDraw)
            tbody.appendChild(tr)
        }

        algo1(cartes, cartes)

    })
}

const algo1 = (carte, cartes) => {
    let mostPlayed = 0
    let nameCard = ""
    let nbVictory = 0
    for(let carte of cartes) {
        if (mostPlayed < carte.played) {
            mostPlayed = carte.played
            nameCard = carte.name
            nbVictory = carte.victory
        }
    }
    const zoneAffichage = document.querySelector("#zoneAffichage")
    zoneAffichage.innerText = "Le nom de la carte qui a joué le plus de partie est " + nameCard + " avec " + mostPlayed + " parties jouées, et " + nbVictory + " victoires."
}

// const algo2 = (carte, cartes) => {

// }

afficherTableau()
