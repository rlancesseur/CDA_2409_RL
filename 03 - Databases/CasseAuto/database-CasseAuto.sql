DROP DATABASE IF EXISTS casseAuto;
CREATE DATABASE IF NOT EXISTS casseAuto;
USE casseAuto;

CREATE TABLE piece(
   piece_id INT AUTO_INCREMENT,
   piece_reference VARCHAR(100) NOT NULL,
   piece_date_recuperation DATE NOT NULL,
   piece_prix_vente SMALLINT NOT NULL,
   PRIMARY KEY(piece_id)
);

CREATE TABLE categorie(
   categorie_id INT AUTO_INCREMENT,
   categorie_nom VARCHAR(30) NOT NULL,
   PRIMARY KEY(categorie_id)
);

CREATE TABLE marque(
   marque_id INT AUTO_INCREMENT,
   marque_nom VARCHAR(30) NOT NULL,
   PRIMARY KEY(marque_id)
);

CREATE TABLE modele(
   modele_id INT AUTO_INCREMENT,
   modele_nom VARCHAR(30) NOT NULL,
   PRIMARY KEY(modele_id)
);

CREATE TABLE convenir(
   piece_id INT,
   modele_id INT,
   PRIMARY KEY(piece_id, modele_id),
   FOREIGN KEY(piece_id) REFERENCES piece(piece_id),
   FOREIGN KEY(modele_id) REFERENCES modele(modele_id)
);

CREATE TABLE construire(
   marque_id INT,
   modele_id INT,
   PRIMARY KEY(marque_id, modele_id),
   FOREIGN KEY(marque_id) REFERENCES marque(marque_id),
   FOREIGN KEY(modele_id) REFERENCES modele(modele_id)
);

CREATE TABLE appartenir(
   piece_id INT,
   categorie_id INT,
   PRIMARY KEY(piece_id, categorie_id),
   FOREIGN KEY(piece_id) REFERENCES piece(piece_id),
   FOREIGN KEY(categorie_id) REFERENCES categorie(categorie_id)
);

