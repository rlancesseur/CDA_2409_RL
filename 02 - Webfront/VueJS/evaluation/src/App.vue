<template>
  <h1>Résultat de l'évaluation</h1>

  <!-- A REFAIRE en utilisant les composants -->
  <form action="" @submit.prevent="ajouterEtudiant">
    <p>Ajouter une note</p>

    <label for="inputName">Nom Prénom : </label>
    <input id="inputName" type="text" v-model="nomEtudiant">
    <br>
    <label for="inputNote">Note : </label>
    <input id="inputNote" type="Number" v-model="noteEtudiant">
    <br>
    <button>Ajouter</button>
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
      <tr v-for="user of evalData">
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

const evalData = ref([])
const nomEtudiant = ref("")
const noteEtudiant = ref("")
let nbEtudiant = ref(0)
let moyClass = ref(0)
let nbDessusMoy = ref(0)
const noteEliminatoire = 12

onMounted(() => {
  fetch('./public/eval.json')
    .then(r => {
      if (r.ok) {
        return r.json()
      }
      throw new Error('Impossible de récupérer le json')
    })
    .then(data => {
      evalData.value = data
    })
    .catch(error => {
      console.error(error)
    })
})

const display = () => {
  nbEtudiant.value = evalData.value.length
  let totalNote = 0

  evalData.value.forEach(element => {
    totalNote += element.grade
    element.isPassed = element.grade >= noteEliminatoire
  })
  moyClass.value = totalNote / nbEtudiant.value

  evalData.value.forEach(element => {
    if (element.grade > moyClass.value) {
      nbDessusMoy.value++
    }
  })
}

const ajouterEtudiant = () => {
  if (inputName.value && inputNote.value != null) {
    evalData.value.push({
      fullname: inputName.value,
      grade: inputNote.value
    })
  }
  display()
}

display()

</script>