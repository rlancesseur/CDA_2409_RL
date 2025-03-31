const myApp = {
    data() {
        return {
            pourcent1: 0,
            nombre1: 0,
            nombre21: 0,
            nombre22: 0,
            nombre3: 0,
            pourcent3: 0,
            plusMoins: '+',
            nombre41: 0,
            nombre42: 0
        }
    },
    computed: {
        result1() {
            return ((this.nombre1 * this.pourcent1) / 100).toFixed(4)
        },
        result2() {
            return this.nombre22 !== 0 ? ((this.nombre21 * 100) / this.nombre22).toFixed(4) : parseInt(0).toFixed(4)
        },
        result3() {
            return this.plusMoins === '+' ? (this.pourcent3 + (this.nombre3 / 100 * this.pourcent3)).toFixed(4) : (this.pourcent3 - (this.nombre3 / 100 * this.pourcent3)).toFixed(4)
        },
        result4() {
            return this.nombre41 !== 0 ? (((this.nombre42 - this.nombre41) / this.nombre41) * 100).toFixed(4) : parseInt(0).toFixed(4)
        }
    }
}

Vue.createApp(myApp).mount('#app')