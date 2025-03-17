<template>
    <div class="labelInput">
        <label :for="idInput"> {{ label }} </label>
        <input
            :id="idInput"
            :type="typeInput"
            :value="modelValue"
            @input="onInputChange"
        />
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
    modelValue: [String, Number],
    typeInput: String,
    idInput: String,
})

const emit = defineEmits(['update:modelValue'])

const onInputChange = (event) => {
    emit('update:modelValue', event.target.value)
}
</script>
