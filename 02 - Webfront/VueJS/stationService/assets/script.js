import { carburants } from "../data/carburants.js"

const myApp = {
    data() {
        return {
            listeCarbu: carburants,
            selectedCarburant: "",
            limite: 0,
            isLitres: false,
            isEuros: false,
            listeFactures: []
        }
    },
    computed: {
        carburantSelectionne() {
            return this.listeCarbu.find(carburant => carburant.nom === this.selectedCarburant) || {}
        },
        prixDuLitre() {
            return this.carburantSelectionne.prix || 0
        },
        prixAPayer() {
            if (this.isEuros) {
                return this.carburantSelectionne.prix * this.limiteEnEuros || 0
            }
            return this.carburantSelectionne.prix * this.limite || 0
        },
        limiteEnEuros() {
            if (this.isEuros) {
                return this.limite / this.prixDuLitre
            }
            return this.limite
        },
        quantiteAVider() {
            if (this.isEuros) {
                return (this.limite / this.prixDuLitre).toFixed(2)
            }
            return this.limite
        },
        totalQuantite() {
            return this.listeFactures.reduce((a,b) => a + parseFloat(b.quantite), 0)
        },
        totalAPayer() {
            return (this.listeFactures.reduce((a,b) => a + parseFloat(b.aPayer), 0)).toFixed(2)
        },
    },
    methods: {
        lancerDistrib() {
            let carburantSelectionne = this.listeCarbu.find((carburant) => carburant.nom === this.selectedCarburant)
            if(!this.isLitres && !this.isEuros) {
                return
            }

            if (this.isLitres && carburantSelectionne.contenu >= this.limite) {
                carburantSelectionne.contenu -= this.limite
            }
            else if (this.isEuros && carburantSelectionne.contenu >= this.limiteEnLitres) {
                carburantSelectionne.contenu -= this.limiteEnEuros
            }

            this.listeFactures.push({
                date: new Date(),
                carburant: this.selectedCarburant,
                prix: this.prixDuLitre,
                quantite: this.limite,
                aPayer: this.prixAPayer
            })
        },
        formatDate(date) {
            const jour = String(date.getDate()).padStart(2, '0')
            const mois = String(date.getMonth()+1).padStart(2, '0')
            const heure = String(date.getHours()).padStart(2, '0')
            const minutes = String(date.getMinutes()).padStart(2, '0')
            const secondes = String(date.getSeconds()).padStart(2, '0')
            return jour + '/' + mois + '/' + date.getFullYear() + ' ' + heure + ':' + minutes + ':' + secondes
        }
    }
}

Vue.createApp(myApp).mount("#app")