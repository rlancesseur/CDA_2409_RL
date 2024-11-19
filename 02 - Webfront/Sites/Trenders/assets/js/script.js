const imgChaussure = document.querySelector("#imgChaussure")
const selectCouleur = document.querySelector("#selectCouleur")
let prix = document.querySelector("#prixArticle")
let titreArticle = document.querySelector("#titreArticle")

selectCouleur.addEventListener("click", () => {
    if(selectCouleur.value === "Bleu") {
        imgChaussure.src = "assets/img/Chaussure.jpg"
        prix.innerText = "127"
        titreArticle.innerText = "Nike sneakers Bleu"
    }
    if(selectCouleur.value === "Rouge") {
        imgChaussure.src = "assets/img/ChaussureRouge.jpg"
        prix.innerText = "99"
        titreArticle.innerText = "Nike sneakers Rouge"
    }
    if(selectCouleur.value === "Rose") {
        imgChaussure.src = "assets/img/ChaussureRose.jpg"
        prix.innerText = "127"
        titreArticle.innerText = "Nike sneakers Rose"
    }
    if(selectCouleur.value === "Noir") {
        imgChaussure.src = "assets/img/ChaussureNoir.avif"
        prix.innerText = "117"
        titreArticle.innerText = "Nike sneakers Noir"
    }
})
