<template>
    <div class="form-grp">
        <label :for="label">{{ label }}</label>
        <input
            type="checkbox"
            :id="label"
            :value="label"
            :checked="selectedNS.includes(label)"
            @change="onInputChange(label)"
        />
    </div>
</template>

<script setup>
const props = defineProps({
    label: String,
    selectedNS: { Array, default: () => [] },
})

const emit = defineEmits(['update:selectedNS'])

const onInputChange = (label) => {
    const index = props.selectedNS.indexOf(label)
    if (index === -1) {
        emit('update:selectedNS', [...props.selectedNS, label])
    } else {
        const updatedNs = [...props.selectedNS]
        updatedNs.splice(index, 1)
        emit('update:selectedNS', updatedNs)
    }
}
</script>
