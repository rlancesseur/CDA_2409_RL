<template>
  <h1>Station Service</h1>

  <div class="containerTypeCarburants">
    <div class="containerH2Carbu">
      <h2>Carburants</h2>
    </div>

    <div class="containerDivCarbu">
      <div v-for="carburant of listeCarbu" class="containerCarburant">
        <span>{{ carburant.nom }}</span>
        <span>{{ carburant.contenu.toFixed(2) }} litres</span>
        <input type="number" :value="carburant.prix" />
      </div>
    </div>
  </div>

  <div class="containerPompes">
    <Pompe :pompe-id="1" :liste-carbu="listeCarbu" @nouvelleFacture="ajouterFacture" />
    <Pompe :pompe-id="2" :liste-carbu="listeCarbu" @nouvelleFacture="ajouterFacture" />
  </div>

  <div v-if="listeFactures.length > 0" class="containerFactures">
    <h2>Factures</h2>

    <table>
      <thead>
        <tr>
          <th>Date/Heure</th>
          <th>Carburant</th>
          <th>Prix/litre</th>
          <th>Quantité</th>
          <th>Prix payé</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="facture of listeFactures" :key="facture.date">
          <td>{{ formatDate(facture.date) }}</td>
          <td>{{ facture.carburant }}</td>
          <td>{{ facture.prix }}</td>
          <td>{{ facture.quantite }}</td>
          <td>{{ facture.aPayer.toFixed(2) }} €</td>
        </tr>
      </tbody>
      <tfoot>
        <td colspan="3">Totaux :</td>
        <td>{{ totalQuantite }} litres</td>
        <td>{{ totalAPayer }} €</td>
      </tfoot>
    </table>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
import { carburants } from './data/carburants.js'
import Pompe from './components/Pompe.vue'

const listeCarbu = ref(carburants)
const listeFactures = ref([])

const totalQuantite = computed(() => {
  return listeFactures.value.reduce((a, b) => a + parseFloat(b.quantite), 0).toFixed(2)
})

const totalAPayer = computed(() => {
  return listeFactures.value.reduce((a, b) => a + parseFloat(b.aPayer), 0).toFixed(2)
})

const ajouterFacture = (facture) => {
  listeFactures.value.push(facture)
}

const formatDate = (date) => {
  const jour = String(date.getDate()).padStart(2, '0')
  const mois = String(date.getMonth() + 1).padStart(2, '0')
  const heure = String(date.getHours()).padStart(2, '0')
  const minutes = String(date.getMinutes()).padStart(2, '0')
  const secondes = String(date.getSeconds()).padStart(2, '0')
  return jour + '/' + mois + '/' + date.getFullYear() + ' ' + heure + ':' + minutes + ':' + secondes
}
</script>
