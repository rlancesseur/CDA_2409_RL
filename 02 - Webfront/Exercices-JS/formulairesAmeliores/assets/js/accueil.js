const getCookie = (nomCookie) => {
    let name = nomCookie + "="
    let ca = document.cookie.split(';')
    for(let i = 0; i < ca.length; i++) {
      let c = ca[i]
      while (c.charAt(0) == ' ') {
        c = c.substring(1)
      }
      if (c.indexOf(name) == 0) {
        return c.substring(name.length, c.length)
      }
    }
    return ""
  }

const ecrireAccueil = () => {
    let prenomCookie = getCookie("firstName")
    let nomCookie = getCookie("lastName")
    let dateCookie = getCookie("date")
    let pseudoCookie = getCookie("pseudo")
    let jourAvantAnniversaire = getCookie("intervalles")
  
    const tbody = document.querySelector("tbody")
    const tr = document.createElement("tr")
  
    const tdPrenom = document.createElement("td")
    tdPrenom.innerText = prenomCookie ? prenomCookie : "Non renseigné"
    tr.appendChild(tdPrenom)
    const tdNom = document.createElement("td")
    tdNom.innerText = nomCookie ? nomCookie : "Non renseigné"
    tr.appendChild(tdNom)
    const tdDate = document.createElement("td")
    tdDate.innerText = dateCookie ? dateCookie : "Non renseigné"
    tr.appendChild(tdDate)
    const tdPseudo = document.createElement("td")
    tdPseudo.innerText = pseudoCookie ? pseudoCookie : "Non renseigné"
    tr.appendChild(tdPseudo)
    tbody.appendChild(tr)
    const tdJourAvantAnni = document.createElement("td")
    tdJourAvantAnni.innerText = jourAvantAnniversaire ? jourAvantAnniversaire : "Non renseigné"
    tr.appendChild(tdJourAvantAnni)
    tbody.appendChild(tr)
  }

  ecrireAccueil()
  