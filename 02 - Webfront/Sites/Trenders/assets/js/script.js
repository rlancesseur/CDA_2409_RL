const imgChaussure = document.querySelector("#imgChaussure")
const selectCouleur = document.querySelector("#selectCouleur")
let prix = document.querySelector("#prixArticle")
let titreArticle = document.querySelector("#titreArticle")

selectCouleur.addEventListener("click", () => {
    if(selectCouleur.value === "Verte") {
        imgChaussure.src = "assets/img/greenShoes.jpg"
        prix.innerText = "127"
        titreArticle.innerText = "DC Shoes Verte"
    }
    if(selectCouleur.value === "Bleu") {
        imgChaussure.src = "assets/img/blueShoes.jpg"
        prix.innerText = "99"
        titreArticle.innerText = "DC Shoes Bleu"
    }
    if(selectCouleur.value === "Jaune") {
        imgChaussure.src = "assets/img/yellowShoes.jpg"
        prix.innerText = "127"
        titreArticle.innerText = "DC Shoes Jaune"
    }
    if(selectCouleur.value === "Noir") {
        imgChaussure.src = "assets/img/blackShoes.jpg"
        prix.innerText = "117"
        titreArticle.innerText = "DC Shoes Noir"
    }
})


const imgChevron = document.querySelector("#imgChevron")
const textCara = document.querySelector("#textCara")

imgChevron.addEventListener("click", () => {

    if (textCara.style.display === "none") {
        textCara.style.display = "block"
        imgChevron.style.transform = "rotate("+ 0 +"deg)"
    }
    else { 
        textCara.style.display = "none"
        imgChevron.style.transform = "rotate("+ 180 +"deg)"
    }
})
