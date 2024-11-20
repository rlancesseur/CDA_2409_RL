//TEST lien icone list =>
let lilles = document.querySelector("#lilles")
let iconLilles = document.querySelector("#iconLilles")

const grandir = ()  => {
    lilles.style.color = '#26C1DC';
    iconLilles.style.transform = 'scale(1.2)';
}

const diminuer = () => {
    lilles.style.color = 'black';
    iconLilles.style.transform = 'scale(1)';
}

lilles.addEventListener("mouseover", grandir);
lilles.addEventListener("mouseout", diminuer);

iconLilles.addEventListener("mouseover", grandir);
iconLilles.addEventListener("mouseout", diminuer);



//CARROUSEL de la honte beaucoup trop long =>
const point1 = document.querySelector(".un")
const point2 = document.querySelector(".deux")
const point3 = document.querySelector(".trois")
const point4 = document.querySelector(".quatre")
const point5 = document.querySelector(".cinq")
const point6 = document.querySelector(".six")
const point7 = document.querySelector(".sept")
const point8 = document.querySelector(".huit")
const imgMuscu = document.querySelector("#imgMuscu")
const imgTraining = document.querySelector("#imgTraining")
const imgNatation = document.querySelector("#imgNatation")
const imgBoxe = document.querySelector("#imgBoxe")
const imgFruits = document.querySelector("#imgFruits")
const imgYoga = document.querySelector("#imgYoga")
const imgCardio = document.querySelector("#imgCardio")
const imgSauna = document.querySelector("#imgSauna")

const point = [point1, point2, point3, point4, point5, point6, point7, point8]
const imgGalerie = [imgMuscu, imgTraining, imgNatation, imgBoxe, imgFruits, imgYoga, imgCardio, imgSauna]

for (let j = 0; j < 9; j++) { 
    point[j].addEventListener("click", () => {
        for(let i = 0; i < imgGalerie.length; i++) {
            imgGalerie[i].style.display = "none"
        }
        imgGalerie[j].style.display = "block"
    })
}
