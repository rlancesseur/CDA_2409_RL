DROP DATABASE IF EXISTS plages;
CREATE DATABASE IF NOT EXISTS plages;
USE plages;

CREATE TABLE IF NOT EXISTS nature_terrain
(
	nature_terrain_id INT AUTO_INCREMENT PRIMARY KEY,
    nature_terrain_type VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS responsable
(
	responsable_id INT AUTO_INCREMENT PRIMARY KEY,
	responsable_nom VARCHAR(100) NOT NULL,
	responsable_prenom VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS departement
(
   departement_id INT AUTO_INCREMENT PRIMARY KEY,
   departement_nom VARCHAR(50) NOT NULL,
   responsable_id INT NOT NULL,
   FOREIGN KEY(responsable_id) REFERENCES responsable(responsable_id)
);


CREATE TABLE IF NOT EXISTS ville
(
	ville_id INT AUTO_INCREMENT PRIMARY KEY,
	ville_nom VARCHAR(30) NOT NULL,
	ville_cp VARCHAR(5),
	ville_nbr_touristes INT NOT NULL,
    departement_id INT NOT NULL,
    FOREIGN KEY(departement_id) REFERENCES departement(departement_id)
);

CREATE TABLE plage 
(
	plage_id INT AUTO_INCREMENT PRIMARY KEY,
	plage_longueur SMALLINT,
	ville_id INT NOT NULL,
	FOREIGN KEY(ville_id) REFERENCES ville(ville_id)
);

CREATE TABLE plage_nature_terrain(
   plage_id INT,
   nature_terrain_id INT,
   PRIMARY KEY(plage_id, nature_terrain_id),
   FOREIGN KEY(plage_id) REFERENCES plage(plage_id),
   FOREIGN KEY(nature_terrain_id) REFERENCES nature_terrain(nature_terrain_id)
);






