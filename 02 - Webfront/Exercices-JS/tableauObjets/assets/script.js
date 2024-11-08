let user = document.querySelector("#user")
let password = document.querySelector("#password")
let btnConnexion = document.querySelector("#btnConnexion")

const api = () => {
    return fetch('assets/users.json')
    .then(response => response.json())
    .then(data => console.log(data))
}

api()
