<template>
    <h1>Employes</h1>
    <h3>This is the current list of employees</h3>

    <div v-if="employesData.length > 0">
        <table>
            <thead>
                <tr>
                    <th>EID</th>
                    <th>Full Name</th>
                    <th>Email</th>
                    <th id="">
                        Monthly salary
                        <button @click="triTableau()" id="btnTri">
                            ▲ <br />
                            ▼
                        </button>
                    </th>
                    <th>Year of birth</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <tr
                    v-for="(employee, indexEmp) of employesData"
                    :key="employee.id"
                >
                    <td>{{ employee.id }}</td>
                    <td>{{ employee.employee_name }}</td>
                    <td>{{ getEmail(employee.employee_name) }}</td>
                    <td>{{ (employee.employee_salary / 12).toFixed(2) }}</td>
                    <td>{{ getYearOfBirth(employee.employee_age) }}</td>
                    <td>
                        <button
                            @click="duplicEmp(employee, indexEmp)"
                            id="btnDuplicate"
                        >
                            Duplicate
                        </button>
                        <button @click="dltEmp(employee.id)" id="btnDelete">
                            Delete
                        </button>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td>{{ employesData.length }}</td>
                    <td></td>
                    <td></td>
                    <td>{{ totalSalary() }}</td>
                    <td></td>
                    <td></td>
                </tr>
            </tfoot>
        </table>
    </div>

    <div id="noEmp" v-else>No employees</div>
</template>

<script setup>
import { computed, onMounted, ref } from 'vue'
import { fetchEmployes } from './utils/fetchEmploye'

const employesData = ref([])

const getEmployes = async () => {
    try {
        employesData.value = await fetchEmployes()
    } catch (e) {
        console.error('Erreur lors du chargement des données :', e)
    }
}

onMounted(getEmployes)

const getEmail = (fullName) => {
    return (
        fullName.split(' ')[0][0].toLowerCase() +
        '.' +
        fullName.split(' ')[1].toLowerCase() +
        '@email.com'
    )
}

const getYearOfBirth = (age) => {
    const currentDate = new Date()
    return currentDate.getFullYear() - age
}

const totalSalary = () => {
    return employesData.value
        .reduce((a, b) => a + b.employee_salary / 12, 0)
        .toFixed(2)
}

const dltEmp = (id) => {
    employesData.value = employesData.value.filter(
        (employee) => employee.id !== id
    )
}

const duplicEmp = (employe, indexEmp) => {
    const newEmployee = { ...employe }

    const nouvelleId = Math.max(...employesData.value.map((e) => e.id)) + 1
    console.log()

    newEmployee.id = nouvelleId
    employesData.value.splice(indexEmp + 1, 0, newEmployee)
}

let trie = false
const triTableau = () => {
    if (!trie) {
        employesData.value.sort((a, b) =>
            a.employee_salary < b.employee_salary ? 1 : -1
        )
        trie = true
    } else {
        employesData.value.sort((a, b) =>
            a.employee_salary < b.employee_salary ? -1 : 1
        )
        trie = false
    }
}
</script>
