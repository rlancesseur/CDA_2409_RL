const myApp = {
    data() {
        return {
            minutes: 25,
            secondes: 0,
            intervalle: null,
            todoList: [],
            nouvelleTache: '',
        }
    },
    methods: {
        decompte() {
            if (this.minutes === 0 && this.secondes === 0) {
                clearInterval(this.intervalle)
                this.intervalle = null
                return

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
        },
        ajouterTache() {
            if(this.nouvelleTache !== '') {
                this.todoList.push({ text: this.nouvelleTache, completed: false })
                this.nouvelleTache = ''
            }
        },
        timerPomodoro() {
            clearInterval(this.intervalle)
            this.intervalle = null
            this.minutes = 25,
            this.secondes = 0
        },
        timerShortBreak() {
            clearInterval(this.intervalle)
            this.intervalle = null
            this.minutes = 5,
            this.secondes = 0
        },
        timerLongBreak() {
            clearInterval(this.intervalle)
            this.intervalle = null
            this.minutes = 10,
            this.secondes = 0
        },
        suppTask(index) {
            return this.todoList.splice(index, 1)
        },
        checkTask(index) {
            this.todoList[index].completed = !this.todoList[index].completed
        }
    }
}

Vue.createApp(myApp).mount('#app')