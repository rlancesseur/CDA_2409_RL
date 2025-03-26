const plateau = document.querySelector('#plateau')
const result = document.querySelector('#result')
const zoneResultat = document.querySelector('.zoneResultat')
const zoneScoreJaune = document.querySelector('#scoreJaune')
const zoneScoreRouge = document.querySelector('#scoreRouge')
const btnRecommencer = document.querySelector('#btnRecommencer')
let scoreJaune = 0
let scoreRouge = 0

const p1 = 'red'
const p2 = 'yellow'
let currentPlayer = p1

const m = [...Array(6)].map(() => Array(7).fill(''))

m.forEach((row, x) => {
    row.forEach((cell, y) => {
        cell = document.createElement('div')
        cell.className = 'case'
        cell.dataset.x = x
        cell.dataset.y = y
        cell.innerHTML = 'x: ' + x + ' <br> ' + 'y: ' + y
        cell.style.background = 'black'
        plateau.append(cell)

        cell.addEventListener('click', () => {     
            const columnIndex = cell.dataset.y

            const columnY = [...document.querySelectorAll(`.case[data-y="${columnIndex}"]`)]
            const foundCase = columnY.reverse().find((c) => c.style.background === 'black')

            foundCase.style.background = currentPlayer
            m[parseInt(foundCase.dataset.x)][parseInt(foundCase.dataset.y)] = currentPlayer

            console.table(m)
            
            if(estGagnant()) {
                plateau.style.display = 'none'
                zoneResultat.style.display = "flex"
                result.innerText = 'Bravo au joueur ' + (currentPlayer === 'red' ? 'rouge' : 'jaune')
                result.style.color = currentPlayer
                if (currentPlayer === 'yellow') {
                    scoreJaune++
                    zoneScoreJaune.innerText = scoreJaune
                } else {
                    scoreRouge++
                    zoneScoreRouge.innerText = scoreRouge
                }
            }
            currentPlayer = currentPlayer === p1 ? p2 : p1
        })
    })
})

const estGagnant = () => {
    const rows = m.length
    const cols = m[0].length

    for(let i = 0; i < rows; i++) {
        for(let j = 0; j < cols - 3; j++) {
            if (m[i][j] == currentPlayer && m[i][j+1] == currentPlayer && m[i][j+2] == currentPlayer && m[i][j+3] == currentPlayer) {
                return true
            }
        }
    }

    for (let i = 0; i < rows - 3; i++) {
        for (let j = 0; j < cols; j++) {
            if (m[i][j] == currentPlayer && m[i+1][j] == currentPlayer && m[i+2][j] == currentPlayer && m[i+3][j] == currentPlayer) {
                return true
            }
        }
    }

    for (let i = 0; i < rows - 3; i++) {
        for (let j = 0; j < cols - 3; j++) {
            if (m[i][j] == currentPlayer && m[i+1][j+1] == currentPlayer && m[i+2][j+2] == currentPlayer && m[i+3][j+3] == currentPlayer) {
                return true
            }
        }
    }

    for (let i = 3; i < rows; i++) {
        for (let j = 0; j < cols - 3; j++) {
            if (m[i][j] == currentPlayer && m[i-1][j+1] == currentPlayer && m[i-2][j+2] == currentPlayer && m[i-3][j+3] == currentPlayer) {
                return true
            }
        }
    }
    return false
}

btnRecommencer.addEventListener("click", () => {
    for (let i = 0; i < m.length; i++) {
        for (let j = 0; j < m[i].length; j++) {
            m[i][j] = ''
        }
    }

    const cases = document.querySelectorAll('.case')
    cases.forEach(element => {
        element.style.background = 'black'
    })

    plateau.style.display = 'grid'
    zoneResultat.style.display = 'none'
    result.innerText = ''

    currentPlayer = p1   
})
