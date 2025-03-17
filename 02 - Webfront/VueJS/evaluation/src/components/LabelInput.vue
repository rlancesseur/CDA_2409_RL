<template>
    <div class="labelInput">
        <label :for="label">{{ label }} :</label>
        <input :type="inputType" :value="modelValue" :id="label" @input="onInputChange"/>
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
    modelValue: [String, Number],
    inputType: String,
})

const emit = defineEmits(['update:modelValue'])

const onInputChange = (event) => {
    emit('update:modelValue', event.target.value)
}

</script>
