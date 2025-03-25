const plateau = document.querySelector('#plateau')

for(let i = 0; i < 6; i++){
    const ligne = document.createElement('div')
    ligne.className = 'ligne'
    plateau.append(ligne)
    for(let j = 0; j < 7; j++){
        const caseLigne = document.createElement('div')
        caseLigne.className = 'case'
        ligne.append(caseLigne)
    }
}