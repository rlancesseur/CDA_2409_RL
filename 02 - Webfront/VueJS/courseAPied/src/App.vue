<template>
    <h1>Résultat de la course</h1>

    <div id="containerStat">
        <div class="stat">{{ nbParticipants }} participants</div>
        <div class="stat" v-if="gagnant != null">
            Gagnant : {{ gagnant.nom }}
        </div>
        <div class="stat">Temps moyen : {{ moyTime }}</div>
    </div>

    <h2>Filtrer</h2>

    <div id="containerCheckBox">
        <div class="containerLabel">
            <input
                type="checkbox"
                id="Allemagne"
                value="Allemagne"
                v-model="selectedPays"
            />
            <label for="Allemagne">Allemagne</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Autriche"
                value="Autriche"
                v-model="selectedPays"
            />
            <label for="Autriche">Autriche</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Belgique"
                value="Belgique"
                v-model="selectedPays"
            />
            <label for="Belgique">Belgique</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Espagne"
                value="Espagne"
                v-model="selectedPays"
            />
            <label for="Espagne">Espagne</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="France"
                value="France"
                v-model="selectedPays"
            />
            <label for="France">France</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Grece"
                value="Grèce"
                v-model="selectedPays"
            />
            <label for="Grece">Grèce</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Italie"
                value="Italie"
                v-model="selectedPays"
            />
            <label for="Italie">Italie</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Pays-Bas"
                value="Pays-Bas"
                v-model="selectedPays"
            />
            <label for="Pays-Bas">Pays-Bas</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Pologne"
                value="Pologne"
                v-model="selectedPays"
            />
            <label for="Pologne">Pologne</label>
        </div>

        <div class="containerLabel">
            <input
                type="checkbox"
                id="Portugal"
                value="Portugal"
                v-model="selectedPays"
            />
            <label for="Portugal">Portugal</label>
        </div>
    </div>

    <table v-if="filteredRunnerData.length > 0">
        <thead>
            <tr>
                <th>Pays</th>
                <th>Nom</th>
                <th>Prénom</th>
                <th>Temps final</th>
                <th>Ecart gagnant</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="runner of filteredRunnerData">
                <td>{{ runner.pays }}</td>
                <td>{{ getNom(runner.nom) }}</td>
                <td>{{ getPrenom(runner.nom) }}</td>
                <td>{{ formatTime1(runner.temps) }}</td>
                <td>{{ calculEcart(runner.temps) }}</td>
            </tr>
        </tbody>
    </table>
</template>

<script setup>
import { computed, onMounted, ref } from 'vue'
import { fetchRunners } from './utils/fetchRunners'

const runnersData = ref([])
const selectedPays = ref([])

const getRunners = async () => {
    try {
        runnersData.value = await fetchRunners()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

const filteredRunnerData = computed(() => {
    if (selectedPays.value.length == 0) {
        return runnersData.value
    }
    return runnersData.value.filter((runner) =>
        selectedPays.value.includes(runner.pays)
    )
})

onMounted(getRunners)

const nbParticipants = computed(() => filteredRunnerData.value.length)

const gagnant = computed(() =>
    filteredRunnerData.value.length > 0
        ? filteredRunnerData.value.reduce((a, b) => (a.temps < b.temps ? a : b))
        : null
)

const moyTime = computed(() => {
    if (filteredRunnerData.value.length > 0) {
        const totalTemps = filteredRunnerData.value.reduce(
            (total, runner) => total + runner.temps,
            0
        )
        return formatTime2(totalTemps / filteredRunnerData.value.length)
    } else {
        return 0
    }
})

const getNom = (fullName) => {
    return fullName.split(' ')[0]
}

const getPrenom = (fullName) => {
    return fullName.split(' ')[1]
}

const formatTime1 = (time) => {
    const minutes = Math.floor(time / 60)
    const secondes = time % 60
    return (
        String(minutes).padStart(2, 0) +
        'min' +
        String(secondes).padStart(2, 0) +
        's'
    )
}

const formatTime2 = (time) => {
    const minutes = Math.floor(time / 60)
    const secondes = (time % 60).toFixed(2)
    return (
        String(minutes).padStart(2, 0) +
        ' minutes et ' +
        String(secondes).padStart(2, 0) +
        ' secondes'
    )
}

const calculEcart = (time) => {
    return '+' + (time - gagnant.value.temps) + 's'
}
</script>
