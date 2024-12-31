<template>
  <h1>Changer la taille du texte</h1>

  <button @click="augmenterTaille">Augmenter la taille du texte</button>
  <button @click="diminuerTaille">Diminuer la taille du texte</button>

  <p>Taille actuelle : {{ taille }} px</p>

  <p id="textAModif">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
    Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
    Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
    Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
  </p>
</template>


<script setup>
import { ref } from 'vue'

const taille = ref(16) 
  
const augmenterTaille = () => {
  if (taille.value < 48) {
    taille.value++
    textAModif.style.fontSize = taille.value + "px"
  }
}

const diminuerTaille = () => {
  taille.value--
  if (taille.value < 8) {
    taille.value = 16
  }
  textAModif.style.fontSize = taille.value + "px"
}
</script>
