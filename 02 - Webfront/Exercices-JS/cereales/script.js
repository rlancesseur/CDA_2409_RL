const inputRechercher = document.querySelector("#inputRechercher")

const affichage = () => {
    fetch("https://arfp.github.io/tp/web/javascript2/10-cereals/cereals.json")
        .then(response => response.json())
        .then(cereals => {

            let nbCereal = 0
            let nbCalorie = 0
            for (let cereal of cereals.data) {
                nbCereal++
                nbCalorie += cereal.calories
                const tbody = document.querySelector("tbody")

                const tr = document.createElement("tr")
                const tdId = document.createElement("td")
                tdId.className = "tdIdStyle"
                const tdName = document.createElement("td")
                tdName.className = "tdNameStyle"
                const tdCalories = document.createElement("td")
                const tdProtein = document.createElement("td")
                const tdSodium = document.createElement("td")
                const tdFiber = document.createElement("td")
                const tdCarbo = document.createElement("td")
                const tdSugars = document.createElement("td")
                const tdPotass = document.createElement("td")
                const tdVitamins = document.createElement("td")
                const tdRating = document.createElement("td")
                const tdNs = document.createElement("td")
                const tdDel = document.createElement("td")
                tdDel.className = "tdDelStyle"

                tdId.innerText = cereal.id
                tdName.innerText = cereal.name
                tdCalories.innerText = cereal.calories
                tdProtein.innerText = cereal.protein
                tdSodium.innerText = cereal.sodium
                tdFiber.innerText = cereal.fiber
                tdCarbo.innerText = cereal.carbo
                tdSugars.innerText = cereal.sugars
                tdPotass.innerText = cereal.potass
                tdVitamins.innerText = cereal.vitamins
                tdRating.innerText = cereal.rating
                const { lettre, couleur } = calculNutriScore(cereal)
                tdNs.innerText = lettre
                tdNs.style.backgroundColor = couleur
                tdDel.innerText = "X"

                tr.appendChild(tdId)
                tr.appendChild(tdName)
                tr.appendChild(tdCalories)
                tr.appendChild(tdProtein)
                tr.appendChild(tdSodium)
                tr.appendChild(tdFiber)
                tr.appendChild(tdCarbo)
                tr.appendChild(tdSugars)
                tr.appendChild(tdPotass)
                tr.appendChild(tdVitamins)
                tr.appendChild(tdRating)
                tr.appendChild(tdNs)
                tr.appendChild(tdDel)
                tbody.appendChild(tr)

                tdDel.addEventListener("click", () => {
                    tr.remove()
                    nbCalorie -= cereal.calories
                    nbCereal--

                    const zoneNbCereal = document.querySelector("#zoneNbCereal")
                    zoneNbCereal.innerText = "Nombre total de céréales : " + nbCereal
                    const zoneMoyenneCalories = document.querySelector("#zoneMoyenneCalories")
                    zoneMoyenneCalories.innerText = "Moyenne calorie : " + Math.round(nbCalorie / nbCereal)
                })
            }
            const zoneNbCereal = document.querySelector("#zoneNbCereal")
            zoneNbCereal.innerText = "Nombre total de céréales : " + nbCereal
            const zoneMoyenneCalories = document.querySelector("#zoneMoyenneCalories")
            zoneMoyenneCalories.innerText = "Moyenne calorie : " + Math.round(nbCalorie / nbCereal)
        })
}

const calculNutriScore = (cereal) => {
    let lettre
    let couleur

    if (cereal.rating < 35) {
        lettre = "E"
        couleur = "#CC0000CC"
    } else if (cereal.rating >= 35 && cereal.rating < 55) {
        lettre = "D"
        couleur = "#CC6600CC"
    } else if (cereal.rating >= 55 && cereal.rating < 70) {
        lettre = "C"
        couleur = "#CCCC00CC"
    } else if (cereal.rating >= 70 && cereal.rating < 80) {
        lettre = "B"
        couleur = "#009900CC"
    } else if (cereal.rating >= 80) {
        lettre = "A"
        couleur = "darkgreen"
    }

    return { lettre, couleur }
}

affichage()