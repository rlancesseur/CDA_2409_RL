const app = Vue.createApp({
    data() {
        return {
            cart: 0,
            product: 'T-Shirt',
            image: 'assets/images/t-shirt-bleu.png',
            inventory: 8,
            details: ['60% coton', '30% laine', '10% polyester'],
            variants: [
                { id: 2234, color: 'bleu', image: './assets/images/t-shirt-bleu.png' },
                { id: 2235, color: 'rouge', image: './assets/images/t-shirt-rouge.png' }
            ]
        }
    },
    methods: {
        addToCart() {
            this.cart += 1
        },
        updateImage(variantImage) {
            this.image = variantImage
        }
    }
})
