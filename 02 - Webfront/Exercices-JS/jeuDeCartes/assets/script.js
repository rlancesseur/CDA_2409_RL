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

        algo1(cartes)
        algo2(cartes, cartes)
    })
}

const algo1 = (cartes) => {
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
    const pAlgo1 = document.createElement("p")
    pAlgo1.innerText = "La carte qui a joué le plus de partie est " + nameCard + " avec " + mostPlayed + " parties jouées, et " + nbVictory + " victoires."
    zoneAffichage.appendChild(pAlgo1)
}

const algo2 = (cartes) => {
    let bestRatio = 0
    let nameCard = ""
    let nbrPlayed = 0
    let nbrVictory = 0
    for(let carte of cartes) {
        let ratio = (carte.victory / carte.played) * 100
        if (bestRatio < ratio) {
            bestRatio = ratio
            nameCard = carte.name
            nbrPlayed = carte.played
            nbrVictory = carte.victory
        }
    }
    const zoneAffichage = document.querySelector("#zoneAffichage")
    const pAlgo2 = document.createElement("p")
    pAlgo2.innerText = "La carte qui a le meilleur ratio victoires/défaites est " + nameCard + " avec " + nbrPlayed 
                        + " parties jouées et " + nbrVictory + " victoires (ratio de " + bestRatio + "%)";
    zoneAffichage.appendChild(pAlgo2)
}

afficherTableau()
