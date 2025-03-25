<template>
    <h1>Liste des ventes</h1>

    <div id="containerFlexSales">
        <div v-for="legumoSale of legumosSalesData" class="containerSales" :key="legumoSale.SaleId">
            <p>
                <span>{{ legumoSale.Name }}</span> <span>({{ legumoSale.SaleWeight }}kgs)</span>
            </p>
            <p>{{ legumoSale.SaleDate }}</p>
        </div>
    </div>
</template>

<script setup>
import { fetchSales } from '@/utils/fetchSales'
import { onMounted, ref } from 'vue'

const legumosSalesData = ref([])

const getSalesLegumos = async () => {
    try {
        legumosSalesData.value = await fetchSales()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(getSalesLegumos)
</script>
