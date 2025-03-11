<template>
    <label> 
        <input type="checkbox" v-model="model">
        {{ label }}
    </label>
</template>


<script setup>
const props = defineProps({
    label: String
})

const model = defineModel()
</script>