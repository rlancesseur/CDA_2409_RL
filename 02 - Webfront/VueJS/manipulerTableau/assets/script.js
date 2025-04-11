const myApp = {
    data() {
        return {
            people: ['Mike Dev', 'John Makenzie', 'Léa Grande'],
            prenom: '',
            nom: '',
            result: '',
        }
    },
    methods: {
        email(person) {
            const prenom = person.split(' ')[1].toLowerCase()
            const nom = person.split(' ')[0].toLowerCase()
            return prenom + '.' + nom + '@example.com'
        },
        addPerson() {
            if (this.prenom && this.nom) {
                const prenom =
                    this.prenom.charAt(0).toUpperCase() +
                    this.prenom.slice(1).toLowerCase()
                const nom =
                    this.nom.charAt(0).toUpperCase() +
                    this.nom.slice(1).toLowerCase()
                this.people.push(prenom + ' ' + nom)
                this.result = prenom + ' ' + nom + ' ajouté !'
                this.prenom = ''
                this.nom = ''
            } else if (!this.prenom) this.result = 'Saisir un prénom'
            else if (!this.nom) this.result = 'Saisir un nom'
        },
        deletePerson(index) {
            this.people.splice(index, 1)
        },
    },
}

Vue.createApp(myApp).mount('#app')
