let form = document.querySelector("form")
let btnConnexion = document.querySelector("#btnConnexion")

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
                alert("Trouvé !")
                return
            }
        }
        alert("Erreur")
    })
})


