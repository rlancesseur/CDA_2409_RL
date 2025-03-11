<template>
    <form action="" @submit.prevent="ajouterTache">
        <fieldset role="group">
            <input type="text" v-model="newTodo" placeholder="Tâches à effectuer">
            <button :disabled="newTodo.length == 0" id="btnValider">Ajouter</button>
        </fieldset>
    </form>
    
    <div v-if="todos.length == 0">Il n'y a pas de tâches</div>
    <div v-else>
        <ul>
            <li v-for="todo in sortedTodos" :key="todo.date" :class="{completed : todo.completed}">
                <Checkbox :label="todo.title" v-model="todo.completed"/>
            </li>
        </ul>

        <label>
            <input type="checkbox" v-model="hideCompleted">
            Masquer les tâches complétées
        </label>
        <p v-if="remainingTodos > 0">
            {{ remainingTodos }} tâche{{ remainingTodos > 1 ? 's' : ''}} à effectuer
        </p>
    </div>
</template>



<script setup>
import { computed, ref } from 'vue';
import Checkbox from './Checkbox.vue';

    const todos = ref([])
    const newTodo = ref("")
    const hideCompleted = ref(false)

    const ajouterTache = () => {
        todos.value.push({
            title: newTodo.value,
            completed: false,
            date: Date.now()
        })
        newTodo.value = ""
    }

    const sortedTodos = computed(() => {
        const sortedTodos = todos.value.toSorted((a, b) => a.completed > b.completed ? 1 : -1)
        if(hideCompleted.value == true) {
            return sortedTodos.filter(t => t.completed == false)
        }
        return sortedTodos
    })

    const remainingTodos = computed(() => {
        return todos.value.filter(t => t.completed === false).length
    })

</script>



<style scoped>
.completed {
    opacity: .5;
    text-decoration: line-through;
}
</style>