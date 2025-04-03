const myApp = {
    data() {
        return {
            minutes: 25,
            secondes: 0,
            intervalle: null,
            enPause: false,
            todoList: [],
            nouvelleTache: '',
        }
    },
    methods: {
        decompte() {
            if (this.minutes === 0 && this.secondes === 0) {
                if (this.enPause) {
                    this.minutes = 25
                    this.secondes = 0
                    this.enPause = false
                } else {
                    this.minutes = 5
                    this.secondes = 0
                    this.enPause = true
                }
            } else {
                if (this.secondes > 0) {
                    this.secondes--
                } else {
                    this.minutes--
                    this.secondes = 59
                }
            }
        },
        demarrerChrono() {
            if (!this.intervalle) {
                this.intervalle = setInterval(this.decompte.bind(this), 1000)
            }
        },
        pauseChrono() {
            clearInterval(this.intervalle)
            this.intervalle = null
        },
        resetChrono() {
            clearInterval(this.intervalle)
            this.intervalle = null
            this.minutes = 25
            this.secondes = 0
            this.enPause = false
        },
        ajouterTache() {
            if(this.nouvelleTache !== '') {
                this.todoList.push(this.nouvelleTache)
                this.nouvelleTache = ''
            }
        }
    }
}

Vue.createApp(myApp).mount('#app')