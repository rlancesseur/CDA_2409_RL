import { createRouter, createWebHistory } from 'vue-router'
import Index from '../views/Index.vue'
import Sales from '../views/Sales.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: Index,
    },
    {
      path: '/sales',
      name: 'sales',
      component: Sales,
    },
  ],
})

export default router
