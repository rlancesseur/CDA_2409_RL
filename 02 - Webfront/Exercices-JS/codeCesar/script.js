const inputTexteEntree = document.querySelector("#inputTexteEntree")
const inputTexteSortie = document.querySelector("#inputTexteSortie")
const inputCle = document.querySelector("#inputCle")
const inputDirection = document.querySelector("#inputDirection")
const btnValider = document.querySelector("#btnValider")

const alphabet = "abcdefghijklmnopqrstuvwxyz".split("")


const dechiffrer = () => {
    const texteEntree = inputTexteEntree.value.toLowerCase().split("")
    console.log(texteEntree)

    //CHIFFREMENT

    
    inputTexteSortie.value = texteEntree.join("")
}

btnValider.addEventListener("click", dechiffrer)