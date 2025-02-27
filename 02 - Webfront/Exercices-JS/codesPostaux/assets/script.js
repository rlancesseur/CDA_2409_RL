const btnValider = document.querySelector("#btnValider")

// const inputCp = document.querySelector("#cp")
// inputCp.addEventListener("input", (event) => {
//     fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
//     .then(response => response.json())
//     .then(villes => {
//         const cp = event.target.value
//         const cpChoice = document.querySelector("#cp-choice")
//         const codesFiltres = villes.filter(code => code.startsWith(cp));

//         codesFiltres.forEach(code => {
//             const option = document.createElement("option")
//             option.value = code
//             cpChoice.appendChild(option)
//         })
//     }) 
// })

btnValider.addEventListener("click", () => {
    zoneAffichage.innerText = ""

    fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
    .then(response => response.json())
    .then(villes => {
        const cp = document.querySelector("#cp").value

        for (let ville of villes) {
            if(cp === ville.codePostal) {
                zoneAffichage.style.display ="block"
                let ul = document.createElement("ul")
                let liCodeCommune = document.createElement("li")
                let liCodePostal = document.createElement("li")
                let liLibelleAcheminement = document.createElement("li")
                let liNomCommune = document.createElement("li")
                liCodeCommune.innerText = "Code commune : " + ville.codeCommune
                liCodePostal.innerText = "Code postal : " + ville.codePostal
                liLibelleAcheminement.innerText = "Libelle acheminement : " + ville.libelleAcheminement
                liNomCommune.innerText = "Nom commune : " + ville.nomCommune
                ul.appendChild(liNomCommune)
                ul.appendChild(liLibelleAcheminement)
                ul.appendChild(liCodePostal)
                ul.appendChild(liCodeCommune)         
                zoneAffichage.appendChild(ul)
            }
        }
    })
})
