<template>
    <header>
        <div id="container-h1">
            <h1>Cereals</h1>
        </div>

        <div id="container-search">
            <Fieldset legend="Rechercher" id="fieldset-rechercher">
                <input
                    type="text"
                    id="inputRechercher"
                    placeholder="Nom du céréale"
                    v-model="inputRechercher"
                />
            </Fieldset>

            <Fieldset legend="Filtrer" id="fieldset-filtrer">
                <Fieldset legend="Nutriscore" id="fieldset-ns">
                    <CheckboxComponent label="A" v-model="selectedNS"/>
                    <CheckboxComponent label="B" v-model="selectedNS"/>
                    <CheckboxComponent label="C" v-model="selectedNS"/>
                    <CheckboxComponent label="D" v-model="selectedNS"/>
                    <CheckboxComponent label="E" v-model="selectedNS"/>
                </Fieldset>

                <Fieldset legend="Catégorie" id="fieldset-categorie">
                    <select name="categories" id="categories-select" v-model="selectedCategory">
                        <option value="tous">Tous</option>
                        <option value="sans-sucre">Sans sucre</option>
                        <option value="pauvre-en-sel">Pauvre en Sel</option>
                        <option value="boost">Boost</option>
                    </select>
                </Fieldset>
            </Fieldset>
        </div>
    </header>

    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>NOM</th>
                <th>CALORIES</th>
                <th>PROTEÏNES</th>
                <th>SEL</th>
                <th>FIBRES</th>
                <th>GLUCIDES</th>
                <th>SUCRE</th>
                <th>POTASSIUM</th>
                <th>VITAMINES</th>
                <th>EVALUATION</th>
                <th>NS</th>
                <th>DEL</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="(cereal, indexCereal) in filteredCerealsData" :key="cereal.id">
                <td id="tdID">{{ cereal.id }}</td>
                <td>{{ cereal.name }}</td>
                <td>{{ cereal.calories }}</td>
                <td>{{ cereal.protein }}</td>
                <td>{{ cereal.sodium }}</td>
                <td>{{ cereal.fiber }}</td>
                <td>{{ cereal.carbo }}</td>
                <td>{{ cereal.sugars }}</td>
                <td>{{ cereal.potass }}</td>
                <td>{{ cereal.vitamins }}</td>
                <td>{{ cereal.rating }}</td>
                <td :class="'color-ns-' + getNs(cereal.rating)">
                    {{ getNs(cereal.rating) }}
                </td>
                <td @click="filteredCerealsData.splice(indexCereal, 1)" id="tdDel">X</td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <td></td>
                <td>{{ filteredCerealsData.length }} éléments</td>
                <td>Moyenne calories {{ getMoyCal() }}</td>
            </tr>
        </tfoot>
    </table>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { fetchCereals } from './assets/utils/fetchCereals'
import Fieldset from './components/FieldsetComponent.vue'
import CheckboxComponent from './components/CheckboxComponent.vue'
import { computed } from 'vue'

const selectedCategory = ref('tous')
const cerealsData = ref([])
const inputRechercher = ref('')
const selectedNS = ref([])

const getCereals = async () => {
    try {
        cerealsData.value = await fetchCereals()
    } catch (e) {
        console.error('Erreur lors du chargement des données:', e)
    }
}

onMounted(getCereals)

const getNs = (rating) => {
    if (rating < 35) return 'E'
    if (rating < 55) return 'D'
    if (rating < 70) return 'C'
    if (rating < 80) return 'B'
    return 'A'
}

const getMoyCal = () => {
    if(filteredCerealsData.value.length === 0) return 0
    return ((filteredCerealsData.value.reduce((a,b) => a + b.calories, 0)) / filteredCerealsData.value.length).toFixed(0)
}

const filteredCerealsData = computed(() => {
    if(inputRechercher.value === '') return cerealsData.value
    return cerealsData.value.filter((cereal => cereal.name.toLowerCase().includes(inputRechercher.value.toLowerCase())))
})

// const filteredCerealsData = computed(() => {
//     if(selectedNS.value === '') return cerealsData.value
//     return cerealsData.value.filter((cereal => selectedNS.value.includes(getNs(cereal.rating))))
// })

// const filteredCerealsData = computed(() => {
//     if(selectedCategory.value === 'tous') return cerealsData.value
// })

</script>
