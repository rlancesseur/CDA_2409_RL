import { carburants } from "../data/carburants.js"

const myApp = {
    data() {
        return {
            listeCarbu: carburants
        }
    }
}

Vue.createApp(myApp).mount("#app")