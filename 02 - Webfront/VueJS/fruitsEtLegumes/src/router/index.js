import { createRouter, createWebHistory } from 'vue-router'
import Index from '../views/Index.vue'
import Sales from '../views/Sales.vue'
import NewSales from '../views/NewSales.vue'
import Legumes from '../views/Legumes.vue'
import NewLegume from '@/views/NewLegume.vue'

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: '/legumes',
            name: 'legumes',
            component: Legumes,
        },
        {
            path: '/newLegume',
            name: 'newLegume',
            component: NewLegume,
        },
        {
            path: '/sales',
            name: 'sales',
            component: Sales,
        },
        {
            path: '/newSales',
            name: 'newSales',
            component: NewSales,
        },
        {
            path: '/',
            name: 'home',
            component: Index,
        },
    ],
})

export default router
