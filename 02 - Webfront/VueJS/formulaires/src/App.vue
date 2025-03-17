<template>
    <form action="" @submit.prevent="addUser">
        <fieldset>
            <legend>Formulaire</legend>

            <Input
                label="Nom : "
                v-model="nom"
                typeInput="text"
                idInput="nom"
            />

            <Input
                label="Prénom : "
                v-model="prenom"
                typeInput="text"
                idInput="prenom"
            />

            <Input
                label="Age : "
                v-model="age"
                typeInput="number"
                idInput="age"
            />

            <input
                type="submit"
                id="btnSubmit"
                :disabled="
                    nom.length === 0 ||
                    prenom.length === 0 ||
                    (!Number.isInteger(age) && age < 1)
                "
            />
        </fieldset>
    </form>

    <Tableau :tab="users" />
</template>

<script setup>
import { onMounted, ref } from 'vue'
import Input from './components/Input.vue'
import Tableau from './components/Tableau.vue'
import { fetchUsers } from './utils/fetchUsers'

const nom = ref('')
const prenom = ref('')
const age = ref(null)
const users = ref([])

const getUsers = async () => {
    try {
        users.value = await fetchUsers()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(() => {
    getUsers()
})

const addUser = () => {
    users.value.push({
        nom: nom.value,
        prenom: prenom.value,
        age: age.value,
    })
    prenom.value = ''
    nom.value = ''
    age.value = ''
}
</script>
