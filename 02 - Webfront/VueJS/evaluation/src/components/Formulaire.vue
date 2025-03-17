<template>
    <form action="" @submit.prevent="ajouterEtudiant">
        <p>Ajouter une note</p>

        <LabelInput label="Nom" v-model="nomEtudiant" inputType="text" />
        <LabelInput label="Note" v-model="noteEtudiant" inputType="number" />
        <button>Ajouter</button>
    </form>
</template>

<script setup>
import { ref } from 'vue'
import LabelInput from './labelInput.vue'

const nomEtudiant = ref('')
const noteEtudiant = ref(null)

const props = defineProps({
    ajouterEtudiant: Function,
})

const ajouterEtudiant = () => {
    props.ajouterEtudiant(nomEtudiant.value, noteEtudiant.value)
    nomEtudiant.value = ''
    noteEtudiant.value = null
}
</script>
