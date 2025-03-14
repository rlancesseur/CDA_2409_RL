<template>
    <h1>Résultat de l'évaluation</h1>

    <Formulaire :ajouterEtudiant="ajouterEtudiant" />

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
import Formulaire from './components/Formulaire.vue'

const evalData = ref([])
const nbEtudiant = ref(0)
const moyClass = ref(0)
const nbDessusMoy = ref(0)
const noteEliminatoire = 12

onMounted(() => {
    fetch('./public/eval.json')
        .then((r) => {
            if (r.ok) {
                return r.json()
            }
            throw new Error('Impossible de récupérer le json')
        })
        .then((data) => {
            evalData.value = data
            display(evalData.value)
        })
        .catch((error) => {
            console.error(error)
        })
})

const display = (ev) => {
    nbEtudiant.value = ev.length
    let totalNote = 0
    nbDessusMoy.value = 0

    ev.sort((a, b) => (a.grade < b.grade ? 1 : -1)).forEach((element) => {
        totalNote += parseFloat(element.grade)
        element.isPassed = element.grade >= noteEliminatoire
    })

    moyClass.value = (totalNote / nbEtudiant.value).toFixed(2)

    ev.forEach((element) => {
        if (element.grade > moyClass.value) {
            nbDessusMoy.value++
        }
    })
}

const ajouterEtudiant = (nom, note) => {
    if (nom.length >= 2 && note >= 0 && note <= 20) {
        evalData.value.push({
            fullname: nom,
            grade: note,
        })
        display(evalData.value)
    }
}
</script>
