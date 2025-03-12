let form = document.querySelector("form")
let btnConnexion = document.querySelector("#btnConnexion")
let btnDeconnexion = document.querySelector("#btnDeconnexion")
let zoneCorrect = document.querySelector("#zoneCorrect")
let zoneIncorrect = document.querySelector("#zoneIncorrect")
let hello = document.querySelector("#hello")
let table = document.querySelector("table")

form.addEventListener("submit", (event) => {
    event.preventDefault()

    let username = document.querySelector("#username").value
    let password = document.querySelector("#password").value

    fetch('assets/users.json')
        .then(response => response.json())
        .then(users => {
            let isoke = false
            for (let user of users) {
                let login = user.firstname + "." + user.lastname
                if (login.toLowerCase() === username && user.password === password) {
                    isoke = true
                    hello.textContent = "Bonjour " + user.firstname + " " + user.lastname
                }
            }
            if (isoke) {
                connecter(users, users)
            }
            else {
                zoneIncorrect.style.display = "block"
                zoneIncorrect.textContent = "Identifiant ou mot de passe incorrect"
                setTimeout(() => {
                    zoneIncorrect.style.display = "none"
                }, 5000)
            }

        })
})

const connecter = (user, users) => {
    form.style.display = "none"
    zoneCorrect.style.display = "block"
    table.innerHTML = ""
    for (user of users) {
        let trElement = document.createElement("tr")
        let tdLastName = document.createElement("td")
        let tdFirstName = document.createElement("td")
        let tdBirthday = document.createElement("td")
        let email = user.firstname + "." + user.lastname + "@example.com"
        let tdEmail = document.createElement("td")
        let tdSalary = document.createElement("td")
        tdLastName.innerText = user.lastname
        tdFirstName.innerText = user.firstname
        tdBirthday.innerText = user.birthday
        tdEmail.innerText = email.toLowerCase()
        tdSalary.innerText = user.salary + " €"
        trElement.appendChild(tdLastName)
        trElement.appendChild(tdFirstName)
        trElement.appendChild(tdBirthday)
        trElement.appendChild(tdEmail)
        trElement.appendChild(tdSalary)
        table.appendChild(trElement)
    }
}

btnDeconnexion.addEventListener("click", () => {
    zoneCorrect.style.display = "none"
    form.style.display = "block"
})


