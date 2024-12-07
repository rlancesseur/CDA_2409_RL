const cases = document.querySelectorAll('.case')
const zoneScore = document.querySelector('#score')
const matrice = []
let index = 0
let score = 0

for (let i = 0; i < 10; i++) {
    matrice[i] = []
    for(let j = 0; j < 10; j++) {
        matrice[i][j] = cases[index]
        index++
    }
}

let positionX = 7;
let positionY = 6;
matrice[positionY][positionX].style.backgroundColor = 'black'

let positionRandomX = Math.ceil(Math.random() * 9)
let positionRandomY = Math.ceil(Math.random() * 9)
matrice[positionRandomY][positionRandomX].style.backgroundColor = 'red'

const deplacer = (newX, newY) => {
    if(positionX === positionRandomX && positionY === positionRandomY) {
        positionRandomX = Math.ceil(Math.random() * 9)
        positionRandomY = Math.ceil(Math.random() * 9)
        if(positionX === positionRandomX && positionY === positionRandomY && positionRandomX > 0){
            positionRandomX -= 1
        }
        else if(positionX === positionRandomX && positionY === positionRandomY && positionRandomY > 0){
            positionRandomY -= 1
        }
        matrice[positionRandomY][positionRandomX].style.backgroundColor = 'red'
        score++
        zoneScore.innerText = score
    }
    if(newX >= 0 && newX <= 9 && newY >= 0 && newY <= 9) {
        matrice[positionY][positionX].style.backgroundColor = 'grey'
        positionX = newX
        positionY = newY
        matrice[positionY][positionX].style.backgroundColor = 'black'
    }
}


document.addEventListener('keydown', (event) => {
    switch (event.key) {
        case 'ArrowUp':
            deplacer(positionX, positionY - 1);
            break;
        case 'ArrowDown':
            deplacer(positionX, positionY + 1);
            break;
        case 'ArrowLeft':
            deplacer(positionX - 1, positionY);
            break;
        case 'ArrowRight':
            deplacer(positionX + 1, positionY);
            break;
    }
})
