<template>
    <h1>Résultat de l'évaluation</h1>

    <form action="" @submit.prevent="ajouterEtudiant">
        <p>Ajouter une note</p>

        <LabelInput label="Nom" v-model="nomEtudiant" inputType="text" />
        <LabelInput label="Note" v-model="noteEtudiant" inputType="number" />
        
        <input id="bntSubmit" type="submit">
    </form>

    <table>
        <thead>
            <tr>
                <th>Nom</th>
                <th>Note</th>
                <th>Obtenu</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="user of evalData" :key="user.fullname">
                <td>{{ user.fullname }}</td>
                <td>{{ user.grade }}</td>
                <td>{{ user.isPassed ? 'Oui' : 'Non' }}</td>
            </tr>
        </tbody>
    </table>

    <ul>
        <li>Nombre d'étudiants : {{ nbEtudiant }}</li>
        <li>Moyenne de la classe : {{ moyClass }}</li>
        <li>Nombre d'étudiants au dessus de la moyenne : {{ nbDessusMoy }}</li>
        <li>Note éliminatoire : {{ noteEliminatoire }}</li>
    </ul>
</template>

<script setup>
import { onMounted, ref } from 'vue'
import LabelInput from './components/LabelInput.vue'
import { fetchUsers } from './utils/fetchUsers'

const evalData = ref([])
const nomEtudiant = ref('')
const noteEtudiant = ref(null)
const nbEtudiant = ref(0)
const moyClass = ref(0)
const nbDessusMoy = ref(0)
const noteEliminatoire = 12

const getUsers = async () => {
    try {
        const data = await fetchUsers()
        evalData.value = data.sort((a, b) => (a.grade < b.grade ? 1 : -1))
        calculStat()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(() => {
    getUsers()
})

//A REFAIRE
// const calculStat = () => {
//     nbEtudiant.value = evalData.value.length
//     let totalNote = 0
//     nbDessusMoy.value = 0

//     evalData.value.forEach((element) => {
//         totalNote += parseFloat(element.grade)
//         element.isPassed = element.grade >= noteEliminatoire
//     })

//     moyClass.value = (totalNote / nbEtudiant.value).toFixed(2)

//     evalData.value.forEach((element) => {
//         if (element.grade > moyClass.value) {
//             nbDessusMoy.value++
//         }
//     })
// }

const ajouterEtudiant = () => {
    if (nomEtudiant.value.length >= 2 && noteEtudiant.value >= 0 && noteEtudiant.value <= 20) {
        evalData.value.push({
            fullname: nomEtudiant.value,
            grade: noteEtudiant.value,
        })
        evalData.value.sort((a, b) => (a.grade < b.grade ? 1 : -1))

        nomEtudiant.value = ''
        noteEtudiant.value = null
        calculStat()
    }    
}
</script>
