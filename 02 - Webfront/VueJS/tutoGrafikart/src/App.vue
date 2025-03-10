<template>
  <h1>Bonjour {{ firstName }}</h1>
  <input type="text" v-model="firstName">
  
  <p :style="{color: count <= 5 ? 'red' : 'green'}">Compteur : {{ count }}</p>
  <button @click="count++">Incrementer</button>
  <button @click="count--">Decrementer</button>

  <div v-if="count > 5">Bravo vous avez cliqué plus de 5 fois</div>
  
  <hr>

  {{ interval }}

  <hr>

  <form action="" @submit.prevent="addMovie">
    <input type="text" placeholder="Nouveau film" v-model="movieName">
    {{ movieName }}
    <br>
    <button>Ajouter</button>
  </form>

  <ul>
    <li v-for="movie in movies" :key="movie">{{ movie }} <button @click="deleteMovie(movie)">Supprimer</button></li>
  </ul>

  <button @click="sortMovies">Réorganiser</button>

  <hr>

  <ul>
    <li v-for="element in person">{{ element }}</li>
  </ul>

  <button @click="randomAge">Changer âge</button>
</template>


<script setup>
import { ref } from 'vue';

  const firstName = ref("Rémi")
  const count = ref(0)
  const interval = ref(0)
  const movies = ref(['Matrix', 'Lilo & Stitch', 'Titanic'])
  const movieName = ref('')

  const deleteMovie = (movie) => {
    movies.value = movies.value.filter(m => m != movie)
  }

  const sortMovies = () => {
    movies.value.sort()
  }

  const addMovie = () => {
    if(movieName.value.length > 0) {
      movies.value.push(movieName.value)
      movieName.value = ''
    }
  }

  setInterval(() => {
    interval.value++
  }, 1000)

  const person = ref({
    firstName : 'John',
    lastName : 'Doe',
    salary : 2000,
    age : 30
  })

  const randomAge = () => {
    person.value.age = Math.round(Math.random() * 100)
  }
</script>


<style scoped>

</style>
