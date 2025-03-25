<template>
    <h1>Liste des légumes</h1>

    <table>
        <thead>
            <tr>
                <th>Nom</th>
                <th>Variété</th>
                <th>Couleur</th>
                <th>Durée Conservation</th>
                <th>Frais</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="legumo of legumosData" :key="legumo.id">
                <td>{{ legumo.Name }}</td>
                <td>{{ legumo.Variety }}</td>
                <td>{{ legumo.PrimaryColor }}</td>
                <td>{{ legumo.LifeTime }}</td>
                <td>{{ legumo.Fresh == 0 ? 'Non' : 'Oui' }}</td>
                <td>Editer . Supprimer</td>
            </tr>
        </tbody>
    </table>
</template>

<script setup>
import { fetchLegumos } from '@/utils/fetchLegumos'
import { onMounted, ref } from 'vue'

const legumosData = ref([])

const getLegumos = async () => {
    try {
        legumosData.value = await fetchLegumos()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(getLegumos)
</script>
