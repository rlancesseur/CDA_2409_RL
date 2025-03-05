const afficherTableau = () => {
    fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
    .then(response => response.json())
    .then(cartes => {
        const tbody = document.querySelector("tbody")
        const champs = ["id", "name", "level", "description", "power", "attack", "armor", "damage", "mitigation", "played", "victory", "defeat", "draw"]

        for (const carte of cartes) {
            const tr = document.createElement("tr");
            for (const champ of champs) {
                const td = document.createElement("td");
                td.innerText = carte[champ] || "";
                tr.appendChild(td);
            }
            tbody.appendChild(tr);
        }

    algo1(cartes)
    algo2(cartes)
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
        let ratio = Math.round((carte.victory / carte.played) * 100)
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
