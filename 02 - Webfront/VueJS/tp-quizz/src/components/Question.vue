<template>
    <div class="questions">
        <h3>{{ question.question }}</h3>
    </div>
</template>

<script setup>
    const propos = defineProps({
        question: Object
    })
</script>