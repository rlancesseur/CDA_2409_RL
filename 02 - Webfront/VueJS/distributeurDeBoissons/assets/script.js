import { boissons } from "../data/boissons.js"

const myApp = {
    data() {
        return {
            boissons: boissons,
            boissonSelectionnee: null,
            montantPaye: 0,
            historiqueAchat: [],
            monnaieAffichee: 0
        }
    },
    computed: {
        montantDue() {
            const result = (this.boissonSelectionnee.tarif - this.montantPaye).toFixed(2)
            return result > 0 ? result : 0
        },
        retourMonnaie() {
            if (this.montantPaye >= this.boissonSelectionnee?.tarif) {
                return (this.montantPaye - this.boissonSelectionnee.tarif).toFixed(2);
            }
        },
        totalPaye() {
            return this.historiqueAchat.reduce((a,b) => a + parseFloat(b.prixBoissonPaye), 0)
        },
        
        afficherMonnaie() {
            setTimeout(() => {
                this.monnaieAffichee = 0
            }, 5000);
            return this.monnaieAffichee;
        }
    },
    methods: {
        selectionnerBoisson(boisson) {
            this.boissonSelectionnee = boisson
            this.montantPaye = 0
        },
        annulerSelection() {
            this.boissonSelectionnee = null
            this.montantPaye = 0
        },
        payerBoisson(montantPiece) {
            this.montantPaye += montantPiece
        },
        formatDate(date) {
            const jour = String(date.getDate()).padStart(2, '0')
            const mois = String(date.getMonth()+1).padStart(2, '0')
            const heure = String(date.getHours()).padStart(2, '0')
            const minutes = String(date.getMinutes()).padStart(2, '0')
            const secondes = String(date.getSeconds()).padStart(2, '0')
            return jour + '/' + mois + '/' + date.getFullYear() + ' ' + heure + ':' + minutes + ':' + secondes
        },
        recupererBoisson() {
            if (this.boissonSelectionnee && this.montantPaye >= this.boissonSelectionnee.tarif) {
                
                this.boissonSelectionnee.stock -= 1

                this.monnaieAffichee = this.retourMonnaie

                this.historiqueAchat.push({
                    dateAchat: new Date(),
                    nomBoissonAchat: this.boissonSelectionnee.nom,
                    prixBoissonAchete: this.boissonSelectionnee.tarif,
                    quantiteBoissonAchete: 1,
                    prixBoissonPaye: this.montantPaye
                })
                this.annulerSelection()
            }
        }
    },
}

Vue.createApp(myApp).mount('#app')