const zoneScore = document.querySelector("span")
const boutonAjouter = document.querySelector("#ajouter")
const boutonReinitialiser = document.querySelector("#reinitialiser")
let score = 0

function comptage() {
    score++;
    zoneScore.innerText = score;
  }

  function reinitialiser() {
    score = 0;
    zoneScore.innerText = score
  }
  
  boutonAjouter.addEventListener("click", comptage);
  boutonReinitialiser.addEventListener("click", reinitialiser);
