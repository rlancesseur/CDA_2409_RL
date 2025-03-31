import { boissons } from "../data/boissons.js"

const myApp = {
    data() {
        return {
            boissons: boissons
        }
    },
}

Vue.createApp(myApp).mount('#app')