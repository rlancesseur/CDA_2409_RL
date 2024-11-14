let imgPoke = document.querySelector("#imgPoke")
let infoPoke = document.querySelector("#infoPoke")
const btnRandom = document.querySelector("#btnRandom")

const afficherPokeRandom = () => {
    imgPoke.innerText = ""
    let nbrRandom = Math.ceil(Math.random() * 150) + 1
    fetch("https://pokeapi.co/api/v2/pokemon/"+nbrRandom)
    .then(response => response.json())
    .then(pokemon => {
        let img = document.createElement("img")
        img.src = pokemon.sprites.front_default
        infoPoke.textContent = pokemon.name
        imgPoke.appendChild(img)
    })
}

afficherPokeRandom()

btnRandom.addEventListener("click", afficherPokeRandom)