DROP DATABASE IF EXISTS aquarium;
CREATE DATABASE IF NOT EXISTS aquarium;
USE aquarium;

CREATE TABLE ordre(
   ordre_id INT AUTO_INCREMENT,
   ordre_nom VARCHAR(100) NOT NULL,
   PRIMARY KEY(ordre_id)
);

CREATE TABLE famille(
   famille_id INT AUTO_INCREMENT,
   famille_nom VARCHAR(100) NOT NULL,
   ordre_id INT NOT NULL,
   PRIMARY KEY(famille_id),
   FOREIGN KEY(ordre_id) REFERENCES ordre(ordre_id)
);

CREATE TABLE genre(
   genre_id VARCHAR(50),
   genre_nom VARCHAR(100) NOT NULL,
   famille_id INT NOT NULL,
   PRIMARY KEY(genre_id),
   FOREIGN KEY(famille_id) REFERENCES famille(famille_id)
);

CREATE TABLE espece(
   espece_id INT AUTO_INCREMENT,
   espece_nom VARCHAR(100) NOT NULL,
   genre_id VARCHAR(50) NOT NULL,
   PRIMARY KEY(espece_id),
   FOREIGN KEY(genre_id) REFERENCES genre(genre_id)
);

CREATE TABLE animal(
   animal_id INT AUTO_INCREMENT,
   animal_nom VARCHAR(100) NOT NULL,
   espece_id INT NOT NULL,
   PRIMARY KEY(animal_id),
   FOREIGN KEY(espece_id) REFERENCES espece(espece_id)
);

CREATE TABLE soin(
   soin_id INT AUTO_INCREMENT,
   soin_nature VARCHAR(100) NOT NULL,
   PRIMARY KEY(soin_id)
);

CREATE TABLE piece(
   piece_id INT AUTO_INCREMENT,
   piece_numero TINYINT NOT NULL,
   PRIMARY KEY(piece_id)
);

CREATE TABLE bassin(
   bassin_id INT AUTO_INCREMENT,
   bassin_numero TINYINT NOT NULL,
   piece_id INT NOT NULL,
   PRIMARY KEY(bassin_id),
   FOREIGN KEY(piece_id) REFERENCES piece(piece_id)
);

CREATE TABLE suivre(
   animal_id INT,
   soin_id INT,
   date_soin DATE,
   PRIMARY KEY(animal_id, soin_id),
   FOREIGN KEY(animal_id) REFERENCES animal(animal_id),
   FOREIGN KEY(soin_id) REFERENCES soin(soin_id)
);

CREATE TABLE accueillir(
   animal_id INT,
   bassin_id INT,
   date_entree DATE NOT NULL,
   date_sortie DATE NOT NULL,
   PRIMARY KEY(animal_id, bassin_id),
   FOREIGN KEY(animal_id) REFERENCES animal(animal_id),
   FOREIGN KEY(bassin_id) REFERENCES bassin(bassin_id)
);
