<template>
    <h1>Ajouter un nouveau légume</h1>

    <form class="formAjout" action="" @submit.prevent="ajouterLegume">
        <FormField label="Nom : " idInput="nameLegume" typeInput="text" v-model="nomLegume" />
        <FormField
            label="Variété : "
            idInput="varietyLegume"
            typeInput="text"
            v-model="varieteLegume"
        />
        <FormField
            label="Couleur : "
            idInput="colorLegume"
            typeInput="text"
            v-model="couleurLegume"
        />
        <FormField
            label="Durée de conservation : "
            idInput="lifeTimeLegume"
            typeInput="number"
            v-model="dureeConservationLegume"
        />
        <FormField
            label="Frais : "
            idInput="freshLegume"
            typeInput="number"
            v-model="estFraisLegume"
        />
        <FormField label="Prix : " idInput="priceLegume" typeInput="number" v-model="prixLegume" />

        <input class="bntSubmit" type="submit" />
    </form>
</template>

<script setup>
import FormField from '@/components/FormField.vue'
import { fetchLegumos } from '@/utils/fetchLegumos'
import { onMounted, ref, watch } from 'vue'

const legumosData = ref([])
const nomLegume = ref('')
const varieteLegume = ref('')
const couleurLegume = ref('')
const dureeConservationLegume = ref(0)
const estFraisLegume = ref(0)
const prixLegume = ref(0)

const getLegumos = async () => {
    try {
        const storedLegumes = localStorage.getItem('legumos');
        if (storedLegumes) {
            legumosData.value = JSON.parse(storedLegumes);
        }
        else {
            legumosData.value = await fetchLegumos()
        }
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(getLegumos)

const ajouterLegume = () => {
    legumosData.value.push({
        Id: 100000,
        Name: nomLegume.value,
        Variety: varieteLegume.value,
        PrimaryColor: couleurLegume.value,
        LifeTime: dureeConservationLegume.value,
        Fresh: estFraisLegume.value,
        Price: prixLegume.value,
    })

    localStorage.setItem('legumos', JSON.stringify(legumosData.value))

    nomLegume.value = ''
    varieteLegume.value = ''
    couleurLegume.value = ''
    dureeConservationLegume.value = 0
    estFraisLegume.value = 0
    prixLegume.value = 0
}
</script>
