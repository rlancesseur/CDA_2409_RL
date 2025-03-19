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
            <input type="checkbox" id="inputAllemagne" />
            <label for="inputAllemagne">Allemagne</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputAutriche" />
            <label for="inputAutriche">Autriche</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputBelgique" />
            <label for="inputBelgique">Belgique</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputEspagne" />
            <label for="inputEspagne">Espagne</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputFrance" />
            <label for="inputFrance">France</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputGrece" />
            <label for="inputGrece">Grèce</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputItalie" />
            <label for="inputItalie">Italie</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputPaysBas" />
            <label for="inputPaysBas">Pays-Bas</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputPologne" />
            <label for="inputPologne">Pologne</label>
        </div>

        <div class="containerLabel">
            <input type="checkbox" id="inputPortugal" />
            <label for="inputPortugal">Portugal</label>
        </div>
    </div>

    <table v-if="runnersData.length > 0">
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
            <tr v-for="runner of runnersData">
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

const getRunners = async () => {
    try {
        runnersData.value = await fetchRunners()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(getRunners)

const nbParticipants = computed(() => runnersData.value.length)

const gagnant = computed(() =>
    runnersData.value.length > 0
        ? runnersData.value.reduce((a, b) => (a.temps < b.temps ? a : b))
        : null
)

const moyTime = computed(() => {
    if (runnersData.value.length > 0) {
        const totalTemps = runnersData.value.reduce(
            (total, runner) => total + runner.temps,
            0
        )
        return formatTime2(totalTemps / runnersData.value.length)
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
