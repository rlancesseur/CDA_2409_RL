import { collectionCars } from './data/cars.js'
const validate = document.querySelector("#validate")
const inputCarName = document.querySelector("#carName")
const result = document.querySelector("#result")
const carChoice = document.querySelector("#car-choice")

validate.addEventListener("click", (event) => {
    event.preventDefault()

    result.innerText = ""
    const carsFilter = collectionCars.filter((car) => car.car_name.toLowerCase().includes(inputCarName.value.toLowerCase()))

    if(inputCarName.value !== "") {
        result.style.display = "block"
        for(let car of carsFilter) {
            const ul = document.createElement("ul")
            const liId = document.createElement("li")
            const liName = document.createElement("li")
            const liAnnee = document.createElement("li")
            const liPays = document.createElement("li")

            liId.innerText = "Id : " + car.car_id
            liName.innerText = "Nom : " + car.car_name
            liAnnee.innerText = "Année : " + car.car_model
            liPays.innerText = "Pays d'origine : " + car.car_origin

            ul.append(liId, liName, liAnnee, liPays)
            result.append(ul)
    }
    inputCarName.value = ""
    }
    else {
        result.style.display ="none"
    }
})

inputCarName.addEventListener("input", () => {
    const listFilter = collectionCars.filter((car) => car.car_name.toLowerCase().startsWith(inputCarName.value.toLowerCase()))

    for(let car of listFilter) {
        const option = document.createElement("option")
        option.innerText = car.car_name
        carChoice.append(option)
    }

})