<template>
    <div class="question">
        <h3>{{ question.question }}</h3>
        <ul>
            <li v-for="(choice, index) in randomChoices" :key="choice">
                <Answer :id="`answer${index}`" :disabled="hasAnswer" :value="choice" @change="onAnswer" v-model="answer" :correctAnswer="question.correct_answer"/>
            </li>
        </ul>
        <!-- <button :disabled="!hasAnswer" @click="emits('answer', answer)">Question suivante</button> -->
    </div>
</template>

<script setup>
import { shuffleArray } from '@/functions/array';
import { computed, onMounted, onUnmounted, ref } from 'vue';
import Answer from './Answer.vue';

    const props = defineProps({
        question: Object
    })

    const emits = defineEmits(['answer'])
    const answer = ref(null)
    const hasAnswer = computed(() => answer.value !== null)
    const randomChoices = computed(() => shuffleArray(props.question.choices))
    let timer

    const onAnswer = (e) => {
        answer.value = e.currentTarget.value
        clearTimeout(timer)
        timer = setTimeout(() => {
            emits('answer', answer.value)
        }, 1_300)
    }
    

    onMounted(() => {
        timer = setTimeout(() => {
            emits('answer', answer.value)
        }, 3_500)
    })

    onUnmounted(() => {
        clearTimeout(timer)
    })
</script>

<style>
.question {
    padding-top: 2rem;
}

.question button {
    margin: auto;
    display: block;
}
</style>