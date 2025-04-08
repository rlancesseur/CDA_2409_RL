const ctx = document.getElementById('myChart')
const app = {
    data() {
        return {
            populations: [],
            chart: new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: [],
                    datasets: [
                        {
                            data: [],
                            label: 'Population',
                            backgroundColor: '#9AD0F5',
                            fill: false,
                        },
                    ],
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    plugins: {
                        legend: {
                            position: 'top',
                        },
                    },
                },
            }),
        }
    },
    async created() {
        let reponse = await fetch(
            'https://arfp.github.io/tp/web/javascript2/40-population/fr_population.json'
        )
        this.populations = await reponse.json()
        this.createChart(this.data1())
    },

    methods: {
        data1() {
            return this.populations.filter((p) => p.annee < 2012)
        },
        data2() {
            return this.populations.filter((p) => p.annee >= 2012)
        },
        createChart(data_) {
            const labels = data_.map((item) => item.annee)
            const dataValues = data_.map((item) => item.population)

            this.chart.data.labels = labels
            this.chart.data.datasets[0].data = dataValues
            this.chart.update()

            console.log(this.chart.data)
        },
    },
}

Vue.createApp(app).mount('#app')
