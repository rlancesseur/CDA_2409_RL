const btnValider = document.querySelector("button")

btnValider.addEventListener("click", () => {
    
    const name = document.querySelector("#name").value
    const zoneInfo = document.querySelector("#zoneInfo")
    const zoneAffichage = document.querySelector("#zoneAffichage")
    zoneAffichage.style.display = "flex"
    fetch("https://api.github.com/users/"+name)
    .then(response => response.json())
    .then(user => {
        zoneInfo.innerText = ""
        zoneImg.innerText = ""
        const ul = document.createElement("ul")
        const liName = document.createElement("li")
        const liDate = document.createElement("li")
        const liFollower = document.createElement("li")
        liName.innerText = user.name || name
        liFollower.innerText = user.followers + " followers"
        const datesplit = (user.created_at).split("T")
        liDate.innerText = "Créé le " + datesplit[0] + " à " + datesplit[1]

        ul.appendChild(liName)
        ul.appendChild(liFollower)
        ul.appendChild(liDate)
        zoneInfo.appendChild(ul)

        const img = document.createElement("img")
        img.src = user.avatar_url
        zoneImg.appendChild(img)
    })
})