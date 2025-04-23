const myApp = {
    data() {
        return {
            listePays: [],
        }
    },
    async created() {
        let reponse = await fetch('./assets/Json/destination.json')
        let json = await reponse.json()

        this.listePays = json
    },
}

Vue.createApp(myApp).mount('#app')
