<template>
    <div class="form-grp">
        <label :for="label">{{ label }}</label>
        <input type="checkbox" :id="label" :value="label" />
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
})
</script>
