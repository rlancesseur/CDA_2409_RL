<template>
  <div class="containerPompe">
    <h2>Pompe n°{{ pompeId }}</h2>
    <select v-model="selectedCarburant" :id="'selectPompe' + pompeId" class="selectPompe">
      <option v-for="(carburant, index) of listeCarbu" :key="index" :value="carburant.nom">
        {{ carburant.nom }}
      </option>
    </select>

    <div class="containerLimite">
      <div class="form-grp">
        <label :for="'limiteNumber' + pompeId">Limite</label>
        <input type="number" :id="'limiteNumber' + pompeId" v-model="limite" min="0" />
      </div>
      <div class="form-grp-check">
        <input type="checkbox" :id="'checkboxLitres' + pompeId" v-model="isLitres" />
        <label :for="'checkboxLitres' + pompeId">litres</label>
      </div>
      <div class="form-grp-check">
        <input type="checkbox" :id="'checkboxEuros' + pompeId" v-model="isEuros" />
        <label :for="'checkboxEuros' + pompeId">€</label>
      </div>
    </div>

    <div class="containerActionPompe">
      <div class="containerLabel">
        <div class="form-grp-action">
          <label for="inputPrixLitre">Prix du litre</label>
          <input type="number" id="inputPrixLitre" v-model="prixDuLitre" disabled />
        </div>
        <span>€</span>
      </div>

      <div class="containerLabel">
        <div class="form-grp-action">
          <label for="inputQuantiteVider">Quantité</label>
          <input type="number" id="inputQuantiteVider" v-model="quantiteAVider" />
        </div>
        <span>litres</span>
      </div>

      <div class="containerLabel">
        <div class="form-grp-action">
          <label for="inputPrixPayer">A payer</label>
          <input type="number" id="inputPrixPayer" v-model="prixAPayer" />
        </div>
        <span>€</span>
      </div>

      <div class="barreRemplissage"></div>

      <button @click="lancerDistrib()" class="btnLancer">Lancer la distribution</button>
    </div>
  </div>
</template>

<script setup>
import { computed, ref } from 'vue'

const props = defineProps({
  pompeId: Number,
  listeCarbu: Array,
})

const emit = defineEmits(['nouvelleFacture'])

const selectedCarburant = ref('')
const limite = ref(0)
const isLitres = ref(false)
const isEuros = ref(false)

const carburantSelectionne = computed(() => {
  return props.listeCarbu.find((carburant) => carburant.nom === selectedCarburant.value) || {}
})

const prixDuLitre = computed(() => {
  return carburantSelectionne.value.prix || 0
})

const prixAPayer = computed(() => {
  if (isEuros.value) {
    return carburantSelectionne.value.prix * limiteEnEuros.value || 0
  }
  return carburantSelectionne.value.prix * limite.value || 0
})

const limiteEnEuros = computed(() => {
  if (isEuros.value) {
    return limite.value / prixDuLitre.value
  }
  return limite.value
})

const quantiteAVider = computed(() => {
  if (isEuros.value) {
    return (limite.value / prixDuLitre.value).toFixed(2)
  }
  return limite.value
})

const lancerDistrib = () => {
  let carburantSelectionne = props.listeCarbu.find(
    (carburant) => carburant.nom === selectedCarburant.value,
  )
  if (limite.value === 0) return

  if (isLitres.value && carburantSelectionne.contenu >= limite.value)
    carburantSelectionne.contenu -= limite.value
  else if (isEuros.value && carburantSelectionne.contenu >= limiteEnEuros.value)
    carburantSelectionne.contenu -= limiteEnEuros.value

  emit('nouvelleFacture', {
    date: new Date(),
    carburant: selectedCarburant.value,
    prix: prixDuLitre.value,
    quantite: quantiteAVider.value,
    aPayer: prixAPayer.value,
  })
}
</script>
