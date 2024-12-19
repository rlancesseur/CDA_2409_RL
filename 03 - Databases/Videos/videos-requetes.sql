/*
REQUETES SQL A IMPLEMENTER
Sous langage : DQL / LRD
Data Query Language
Langage de requête sur les données
Principales instructions : 
SELECT : Sélectionner des données existantes dans 1 ou plusieurs tables
*/
USE videos;

-- 1. Sélectionner tous les acteurs (nom, prénom)
SELECT acteur_nom, acteur_prenom FROM acteur;

-- 2. Sélectionner l'acteur dont l'identifiant est différent de "2" 
SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_id = 2;

-- 3. Sélectionner l'acteur dont le nom est "Réno"
SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_nom = "Réno";

-- 4. Sélectionner les acteurs dont le prénom commence par "E"
SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_prenom LIKE "E%";

-- 5. Sélectionner les acteurs dont le prénom se termine par "n"
SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_nom LIKE "%n";

-- 6. Sélectionner les acteurs dont le prénom contient la lettre "a"
SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_prenom LIKE "%a%";

-- 7. Sélectionner tous les acteurs dont le prénom fait partie de la liste ["Jean", "Eva"]
SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_prenom IN ("Jean", "Eva");

SELECT acteur_nom, acteur_prenom
FROM acteur
WHERE acteur_prenom = "Jean" OR acteur_prenom = "Eva"; -- Ca revient au même mais c'est plus long

/* 8. Sélectionner les réalisateurs (nom, prénom) triés par nom et par ordre décroissant */
SELECT realisateur_nom, realisateur_prenom
FROM realisateur
ORDER BY realisateur_nom DESC;