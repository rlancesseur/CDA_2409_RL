<template>
    <fieldset>
        <legend>{{ legend }}</legend>
        <slot></slot>
    </fieldset>
</template>

<script setup>
const props = defineProps({
    legend: String,
})
</script>
