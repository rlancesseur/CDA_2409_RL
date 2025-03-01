let inputDate = document.querySelector("#inputDate")
let btnDate = document.querySelector("#btnDate")
let inputHeure = document.querySelector("#inputHeure")
let btnHeure = document.querySelector("#btnHeure")

btnDate.addEventListener("click", () => {
    let currentDate = new Date()
    let jour = currentDate.getDate() < 10 ? "0" + currentDate.getDate() : currentDate.getDate()
    let mois = (currentDate.getMonth() + 1 < 10) ? "0" + (currentDate.getMonth() + 1) : currentDate.getMonth() + 1
    let annee = currentDate.getFullYear()
    
    inputDate.value = jour + "/" + mois + "/" + annee
})

btnHeure.addEventListener("click", () => {
    let currentDate = new Date()
    let heure = currentDate.getHours() < 10 ? "0" + currentDate.getHours() : currentDate.getHours()
    let minute = currentDate.getMinutes() < 10 ? "0" + currentDate.getMinutes() : currentDate.getMinutes()
    let seconde = currentDate.getSeconds() < 10 ? "0" + currentDate.getSeconds() : currentDate.getSeconds()

    inputHeure.value = heure + ":" + minute + ":" + seconde
})
