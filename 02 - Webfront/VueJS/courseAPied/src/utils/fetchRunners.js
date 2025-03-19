export const fetchRunners = async () => {
    try {
        const response = await fetch('../public/resultat10000metres.json')
        if(!response.ok) {
            throw new Error("Erreur de chargement des données")
        }
        return (await response.json()).sort((a, b) => (a.temps < b.temps ? -1 : 1))
    }
    catch (error) {
        console.error('Erreur', error)
        return []
    }
}