export const fetchUsers = async () => {
    try {
        const response = await fetch('../public/users.json')
        if(!response.ok) {
            throw new Error("Erreur de chargement des données")
        }
        return (await response.json())
    }
    catch (error) {
        console.error('Erreur', error)
        return []
    }
}