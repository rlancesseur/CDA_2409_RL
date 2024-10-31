let lilles = document.querySelector("#lilles")
let iconLilles = document.querySelector("#iconLilles")

function grandir() {
    lilles.style.color = '#26C1DC';
    iconLilles.style.transform = 'scale(1.2)';
}

function diminuer() {
    lilles.style.color = 'black';
    iconLilles.style.transform = 'scale(1)';
}

lilles.addEventListener("mouseover", grandir);
lilles.addEventListener("mouseout", diminuer);

iconLilles.addEventListener("mouseover", grandir);
iconLilles.addEventListener("mouseout", diminuer);
