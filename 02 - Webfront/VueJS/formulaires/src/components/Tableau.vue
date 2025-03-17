<template>
    <table>
        <tr v-if="tab.length !== 0">
            <th>Nom</th>
            <th>Prénom</th>
            <th>Age</th>
        </tr>
        <tr v-for="user of tab">
            <td>{{ user.nom }}</td>
            <td>{{ user.prenom }}</td>
            <td :style="{ color: user.age > 17 ? 'green' : 'red' }">
                {{ user.age }}
            </td>
        </tr>
    </table>
</template>

<script setup>
const props = defineProps({
    tab: Array,
})
</script>
