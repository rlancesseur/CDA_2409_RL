<template>
    <h1>Ajouter une nouvelle vente</h1>

    <form class="formAjout" action="" @submit.prevent="ajouterVente">
        <FormField
            label="Date de la vente : "
            idInput="saleDate"
            typeInput="Date"
            v-model="dateVente"
        />
        <FormField label="Poids : " idInput="saleWeight" typeInput="number" v-model="poidsVente" />
        <FormField
            label="Prix unitaire : "
            idInput="SaleUnitPrice"
            typeInput="number"
            v-model="prixUnitaireVente"
        />
        <FormField
            label="Vente active : "
            idInput="SaleActive"
            typeInput="number"
            v-model="venteActive"
        />
        <FormField
            label="Id du légume : "
            idInput="VegetableId"
            typeInput="number"
            v-model="idLegumos"
        />

        <input class="bntSubmit" type="submit" />
    </form>
</template>

<script setup lang="ts">
import FormField from '@/components/FormField.vue'
import { fetchSales } from '@/utils/fetchSales'
import { onMounted, ref } from 'vue'

const legumosSalesData = ref([])
const dateVente = ref(null)
const poidsVente = ref(0)
const prixUnitaireVente = ref(0)
const venteActive = ref(0)
const idLegumos = ref(0)

const getSalesLegumos = async () => {
    try {
        legumosSalesData.value = await fetchSales()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(getSalesLegumos)

const ajouterVente = () => {
    legumosSalesData.value.push({
        SaleId: 100000,
        SaleDate: dateVente.value,
        SaleWeight: poidsVente.value,
        SaleUnitPrice: prixUnitaireVente.value,
        SaleActive: venteActive.value,
        VegetableId: idLegumos.value,
        Name: 'legumoooos',
        Variety: 'délanatoure',
    })

    console.log(legumosSalesData)
}
</script>
