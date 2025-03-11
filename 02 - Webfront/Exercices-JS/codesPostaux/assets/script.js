const btnValider = document.querySelector("#btnValider")
const inputCp = document.querySelector("#cp")
const cpChoice = document.querySelector("#cp-choice")
const form = document.querySelector("form")

const getVilles = async () => {
    try {
        const response = await fetch('https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json')
        if (!response.ok) {
            throw new Error('Erreur de chargement des données')
        }
        return await response.json()
    }
    catch (error) {
        console.error('Erreur', error)
        return []
    }
}

inputCp.addEventListener("input", () => {

    getVilles().then(villes => {
        cpChoice.innerText = ""
        const result = villes.filter(ville => ville.codePostal.startsWith(inputCp.value))

        result.forEach(element => {
            const option = document.createElement("option")
            option.value = element.codePostal
            option.textContent = element.nomCommune
            cpChoice.appendChild(option)
        })
    })
})

form.addEventListener("submit", (e) => {
    e.preventDefault()
    zoneAffichage.innerText = ""

    getVilles().then(villes => {

        for (let ville of villes) {
            if (inputCp.value === ville.codePostal) {
                zoneAffichage.style.display = "block"
                let ul = document.createElement("ul")
                let liCodeCommune = document.createElement("li")
                let liCodePostal = document.createElement("li")
                let liLibelleAcheminement = document.createElement("li")
                let liNomCommune = document.createElement("li")
                liCodeCommune.innerText = "Code commune : " + ville.codeCommune
                liCodePostal.innerText = "Code postal : " + ville.codePostal
                liLibelleAcheminement.innerText = "Libelle acheminement : " + ville.libelleAcheminement
                liNomCommune.innerText = "Nom commune : " + ville.nomCommune
                ul.append(liNomCommune, liLibelleAcheminement, liCodePostal, liCodeCommune)
                zoneAffichage.appendChild(ul)
            }
        }
    })
})
