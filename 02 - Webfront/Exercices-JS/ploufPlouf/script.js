const input1 = document.querySelector("#input1")
const input2 = document.querySelector("#input2")
const nbrSortie = document.querySelector("#nbrSortie")
const btnPlouf = document.querySelector("#btnPlouf")
const zoneResultat = document.querySelector("#zoneResultat")

const tirage = () => {

    let min = 0
    let max = 0
    if(input1.value < input2.value) {
        min = input1.value
        max = input2.value
    }
    else {
        min = input2.value
        max = input1.value
    }

    let tabNbr = []
    let suiteResultat = ""
    const difference = max - min
    tabNbr.length = difference

    for (let i = 0; i <= difference; i++) {
        tabNbr[i] = min
        min++
    }

    if (nbrSortie.value < 1) nbrSortie.value = 1

    for (let i = 0; i < nbrSortie.value; i++) {
        const indexRandom = Math.floor(Math.random() * difference)
        const resultat = tabNbr[indexRandom]
        suiteResultat += resultat + " "
    }

    zoneResultat.innerHTML = suiteResultat
}

btnPlouf.addEventListener("click", tirage)
