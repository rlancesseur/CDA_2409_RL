<template>
    <h1>Résultat de l'évaluation</h1>

    <form action="" @submit.prevent="ajouterEtudiant">
        <p>Ajouter une note</p>

        <LabelInput label="Nom" v-model="nomEtudiant" inputType="text" />
        <LabelInput label="Note" v-model="noteEtudiant" inputType="number" />

        <input id="bntSubmit" type="submit" />
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
                <td>{{ nomSplit(user.fullname) }}</td>
                <td>{{ prenomSplit(user.fullname) }}</td>
                <td>{{ user.grade }}</td>
                <td>{{ estPasse(user.grade) }}</td>
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
import { computed, onMounted, ref } from 'vue'
import LabelInput from './components/LabelInput.vue'
import { fetchUsers } from './utils/fetchUsers'

const evalData = ref([])
const nomEtudiant = ref('')
const noteEtudiant = ref(null)
const noteEliminatoire = 12

const getUsers = async () => {
    try {
        const data = await fetchUsers()
        evalData.value = data.sort((a, b) => (a.grade < b.grade ? 1 : -1))
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(() => {
    getUsers()
})

const nbEtudiant = computed(() => evalData.value.length)

const moyClass = computed(() => {
    const totalNote = evalData.value.reduce(
        (acc, student) => acc + parseFloat(student.grade),
        0
    )
    return (totalNote / nbEtudiant.value).toFixed(2)
})

const nbDessusMoy = computed(() => {
    const moyenne = parseFloat(moyClass.value)
    return evalData.value.filter(
        (student) => parseFloat(student.grade) > moyenne
    ).length
})

const estPasse = (note) => {
    if (note >= noteEliminatoire) {
        return 'Oui'
    } else {
        return 'Non'
    }
}

const nomSplit = (fullname) => {
    return fullname.split(' ')[0]
}

const prenomSplit = (fullname) => {
    return fullname.split(' ')[1]
}

const ajouterEtudiant = () => {
    if (
        nomEtudiant.value.length >= 2 &&
        noteEtudiant.value >= 0 &&
        noteEtudiant.value <= 20
    ) {
        evalData.value.push({
            fullname: nomEtudiant.value,
            grade: noteEtudiant.value,
        })
        evalData.value.sort((a, b) => (a.grade < b.grade ? 1 : -1))

        nomEtudiant.value = ''
        noteEtudiant.value = null
    }
}
</script>
