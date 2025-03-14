<template>
    <form action="" @submit.prevent="ajouterEtudiant">
        <p>Ajouter une note</p>

        <div class="labelInput">
            <label for="inputName">Nom Prénom : </label>
            <input id="inputName" type="text" v-model="nomEtudiant" />
        </div>

        <div class="labelInput">
            <label for="inputNote">Note : </label>
            <input id="inputNote" type="Number" v-model="noteEtudiant" />
        </div>

        <button>Ajouter</button>
    </form>
</template>

<script setup>
import { ref } from 'vue'

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
