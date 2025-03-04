const inputTexteEntree = document.querySelector("#inputTexteEntree")
const inputTexteSortie = document.querySelector("#inputTexteSortie")
const inputCle = document.querySelector("#inputCle")
const inputDirection = document.querySelector("#inputDirection")
const btnValider = document.querySelector("#btnValider")

btnValider.addEventListener("click", () => {
    const alphabet = "abcdefghijklmnopqrstuvwxyz"
    let texteEntree = inputTexteEntree.value.toLowerCase().split("")
    let indexEntree = []
    let texteSortie = []

    for (let i = 0; i < texteEntree.length; i++) {
        for (let j = 0; j < alphabet.length; j++) {
            if (texteEntree[i] === alphabet[j]) {
                indexEntree.push(j)
            }  
        }
    }

    if (inputCle.value !== "") {
        const cle = parseInt(inputCle.value, 10)
        let indexSortie = []

        if (inputDirection.value == "gauche") {
            indexSortie = indexEntree.map((x) => (x - cle + alphabet.length) % alphabet.length)
        } else {
            indexSortie = indexEntree.map((x) => (x + cle) % alphabet.length)
        }

        let indexSortieIndex = 0
        for (let i = 0; i < texteEntree.length; i++) {
            if (texteEntree[i] === " ") {
                texteSortie[i] = " "
            } else {
                texteSortie[i] = alphabet[indexSortie[indexSortieIndex]]
                indexSortieIndex++
            }
        }

        inputTexteSortie.value = texteSortie.join("")
    }
})
