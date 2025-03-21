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
                />
            </Fieldset>

            <Fieldset legend="Filtrer" id="fieldset-filtrer">
                <Fieldset legend="Nutriscore" id="fieldset-ns">
                    <CheckboxComponent label="A" />
                    <CheckboxComponent label="B" />
                    <CheckboxComponent label="C" />
                    <CheckboxComponent label="D" />
                    <CheckboxComponent label="E" />
                </Fieldset>

                <Fieldset legend="Catégorie" id="fieldset-categorie">
                    <select name="categories" id="categories-select">
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
                <th id="thNom">NOM</th>
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
            <tr v-for="cereal in cerealsData" :key="cereal.id">
                <td id="tdID">{{ cereal.id }}</td>
                <td id="tdNom">{{ cereal.name }}</td>
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
                <td id="tdDel">X</td>
            </tr>
        </tbody>
    </table>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import { fetchCereals } from './assets/utils/fetchCereals'
import Fieldset from './components/FieldsetComponent.vue'
import CheckboxComponent from './components/CheckboxComponent.vue'

const cerealsData = ref([])

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
</script>
