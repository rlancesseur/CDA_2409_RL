export const fetchEmployes = async () => {
    try {
        const response = await fetch('https://arfp.github.io/tp/web/javascript2/03-employees/employees.json')
        if(!response.ok){
            throw new Error("Erreur de chargement des données")
        }
        return (await response.json()).data
    }
    catch (error) {
        console.error('Erreur', error)
        return []
    }
}