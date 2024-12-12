DROP DATABASE IF EXISTS plages;
CREATE DATABASE IF NOT EXISTS plages;
USE plages;

CREATE TABLE IF NOT EXISTS nature_terrain
(
	nature_terrain_id INT AUTO_INCREMENT PRIMARY KEY,
    nature_terrain_type VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS ville
(
	ville_id INT AUTO_INCREMENT PRIMARY KEY,
	ville_nom VARCHAR(30) NOT NULL,
	ville_cp VARCHAR(5),
	ville_nbr_touristes INT NOT NULL
);