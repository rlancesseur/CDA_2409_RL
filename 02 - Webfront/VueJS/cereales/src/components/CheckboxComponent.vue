<template>
    <div class="form-grp">
        <label :for="label">{{ label }}</label>
        <input type="checkbox" :id="label" :value="label" @change="onInputChange"/>
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
})

const emit = defineEmits(['update:label'])

const onInputChange = (event) => {
    emit('update:label', event.target.value)
}
</script>
