const myApp = {
    data() {
        return {
            minutes: 25,
            secondes: 0,
            intervalle: null
        }
    },
    methods: {
        decompte() {
            if (this.minutes === 0 && this.secondes === 0) {
                clearInterval(this.intervalle)
                this.intervalle = null
                return
            }
            if (this.secondes > 0) {
                this.secondes--
            } else {
                this.minutes--
                this.secondes = 59
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
        }
    }
}

Vue.createApp(myApp).mount('#app')