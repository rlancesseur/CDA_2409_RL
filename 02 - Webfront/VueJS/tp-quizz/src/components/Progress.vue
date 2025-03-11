<template>
    Etape {{ value + 1 }} / {{ max + 1 }}
    <progress :value="value" :max="max" />
</template>

<script setup>
    defineProps({
        value: Number,
        max: Number
    })
</script>