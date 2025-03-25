<template>
    <div class="form-grp">
        <label :for="idInput">{{ label }} </label>
        <input :type="typeInput" :id="idInput" :value="modelValue" @input="onInputChange" />
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
    idInput: String,
    typeInput: String,
    modelValue: [String, Number],
})

const emit = defineEmits(['update:modelValue'])

const onInputChange = (event) => {
    emit('update:modelValue', event.target.value)
}
</script>
