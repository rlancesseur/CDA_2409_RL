<template>
  <h1>Compteur de clics</h1>
  <button @click="incrementer">Incrémenter</button>
  <button @click="decrementer">Décrémenter</button>
  <button @click="count = 0">Réinitialiser</button>
  <p>Vous avez cliqué : {{ count }} fois</p>
</template>

<script setup>
import {ref} from 'vue'

const count = ref(0)
const incrementer = () => {
  count.value++
}
const decrementer = () => {
  count.value--
}
</script>

<style>
button {
  margin-right: 5px;
}
</style>