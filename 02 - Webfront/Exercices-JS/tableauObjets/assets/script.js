let form = document.querySelector("form")
let btnConnexion = document.querySelector("#btnConnexion")
let zoneCorrect = document.querySelector("#zoneCorrect")
let hello = document.querySelector("#hello")

form.addEventListener("submit", (event) => {
    event.preventDefault()

    let username = document.querySelector("#username").value
    let password = document.querySelector("#password").value

    fetch('assets/users.json')
    .then(response => response.json())
    .then(data => {
        for (let user of data) {
            let login = user.firstname + "." + user.lastname
            if (login.toLowerCase() === username && user.password === password) {
                form.style.display = "none"
                zoneCorrect.style.display = "block"
                hello.textContent = "Bonjour " + user.firstname + " " + user.lastname
                return
            }
        }
        zoneIncorrect.style.display = "block"
        zoneIncorrect.textContent = "Identifiant ou mot de passe incorrect"
        setTimeout(() => {
            zoneIncorrect.style.display = "none"
        }, 5000)
        
    })
})


