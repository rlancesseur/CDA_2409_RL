const affichage = () => {
    fetch("https://arfp.github.io/tp/web/javascript2/10-cereals/cereals.json")
        .then(response => response.json())
        .then(cereals => {

            const updateLocalStorage = (tabCereals) => {
                localStorage.setItem('cereals', JSON.stringify(tabCereals));
            }

            const afficherCereales = (tabCereals) => {
                const tbody = document.querySelector("tbody")
                tbody.innerText = ""

                let nbCereal = 0
                let nbCalorie = 0

                tabCereals.forEach(cereal => {
                    nbCereal++
                    nbCalorie += cereal.calories

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

                        updateLocalStorage(tabCereals)
                    })
                })
                const zoneNbCereal = document.querySelector("#zoneNbCereal")
                zoneNbCereal.innerText = "Nombre total de céréales : " + nbCereal
                const zoneMoyenneCalories = document.querySelector("#zoneMoyenneCalories")
                zoneMoyenneCalories.innerText = "Moyenne calorie : " + Math.round(nbCalorie / nbCereal)

                updateLocalStorage(tabCereals)
            }

            afficherCereales(cereals.data)

            document.querySelector("#inputRechercher").addEventListener("change", () => {
                const tbody = document.querySelector("tbody")
                tbody.innerText = ""

                let cerealRechercher = document.querySelector("#inputRechercher").value.toLowerCase()
                const regexCereal = new RegExp(cerealRechercher)
                let cerealFiltre = cereals.data.filter(cereal => regexCereal.test(cereal.name.toLowerCase()))

                afficherCereales(cerealFiltre)
            })

            let cerealsEnLocal = localStorage.getItem('cereals');
            if (cerealsEnLocal) {
                afficherCereales(JSON.parse(cerealsEnLocal));
            } else {
                afficherCereales(cereals.data);
            }

            // document.querySelector("#categories-select").addEventListener("change", () => {
            //     let nutriscoreSelectionne = document.querySelector("#categories-select")

            //     let nutriscoreFiltre = cereals.data.filter(cereal => {
            //         const { lettre } = calculNutriScore(cereal)
            //         return lettre === nutriscoreSelectionne.value
            //     })

            //     afficherCereales(nutriscoreFiltre)
            // })
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
