/* commentaire */
-- commentaire

DROP DATABASE IF EXISTS videos;

CREATE DATABASE IF NOT EXISTS videos;

USE videos;

-- On peut aussi écrire "CREATE TABLE IF NOT EXISTS vidéos.film" sans écrire "USE videos" avant
CREATE TABLE IF NOT EXISTS film
(
	film_id INT AUTO_INCREMENT PRIMARY KEY,
    film_titre VARCHAR(255) NOT NULL,
    film_duree SMALLINT NOT NULL
);

INSERT INTO film 
VALUES
(NULL, 'Léon', 120),
(NULL, 'E.T', 90),
(NULL, 'ça', 103);

-- On peut insérer des données sans respecter l'ordre en précisant :

INSERT INTO film 
(film_titre, film_duree)
VALUES
('L\'exorciste', 240),
('Super Papa', 87),
('Gladiator 2', 117);

SELECT * FROM film;

SELECT film_id, film_titre FROM film;
