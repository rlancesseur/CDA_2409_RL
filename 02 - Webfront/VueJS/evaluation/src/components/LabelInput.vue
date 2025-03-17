<template>
    <div class="labelInput">
        <label :for="label">{{ label }} :</label>
        <input :type="inputType" :value="model" :id="label" />
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
    model: String,
    inputType: String,
})
</script>
