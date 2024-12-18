/*
Création de la base de données
Sous langage : DDL / LDD
Data Definition Language
Langue de définition des données
Pincipales insructions :
CREATE = Créer une structure (DATABASE, TABLE, VIEW, PROCEDURE, TRIGGER, FUNTION)
ALTER = Modifier une structure existante
DROP = Supprimer une structure existante
*/

DROP DATABASE IF EXISTS videos;
CREATE DATABASE videos;
USE videos;

-- On peut aussi écrire "CREATE TABLE IF NOT EXISTS vidéos.realisateur" sans écrire "USE videos" avant
CREATE TABLE IF NOT EXISTS realisateur
(
	realisateur_id INT AUTO_INCREMENT PRIMARY KEY,
	realisateur_nom VARCHAR(100) NOT NULL,
	realisateur_prenom VARCHAR(100) NOT NULL
);

CREATE TABLE acteur 
(
	acteur_id INT AUTO_INCREMENT,
    acteur_nom VARCHAR(100) NOT NULL,
	acteur_prenom VARCHAR(100) NOT NULL,
    PRIMARY KEY (acteur_id)
);

CREATE TABLE film
(
	film_id INT AUTO_INCREMENT,
    film_titre VARCHAR(255) NOT NULL,
    film_duree SMALLINT NOT NULL,
    realisateur_id INT,
    PRIMARY KEY (film_id),
    FOREIGN KEY(realisateur_id) REFERENCES realisateur(realisateur_id)
);

CREATE TABLE film_acteur
(
	film_id INT,
    acteur_id INT,
    PRIMARY KEY(film_id, acteur_id),
    FOREIGN KEY(film_id) REFERENCES film(film_id),
    FOREIGN KEY(acteur_id) REFERENCES acteur(acteur_id)
);
