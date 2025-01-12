DROP DATABASE IF EXISTS fanrock;
CREATE DATABASE IF NOT EXISTS fanrock;
USE fanrock;

CREATE TABLE IF NOT EXISTS artiste
(
	artiste_id INT AUTO_INCREMENT PRIMARY KEY,
    artiste_nom VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS label
(
	label_id INT AUTO_INCREMENT PRIMARY KEY,
	label_nom VARCHAR(30) NOT NULL
);

CREATE TABLE compilation
(
   compilation_id INT AUTO_INCREMENT PRIMARY KEY,
   compilation_titre VARCHAR(30) NOT NULL,
   compilation_annee DATE NOT NULL
);

CREATE TABLE album
(
	album_id INT AUTO_INCREMENT,
    album_titre VARCHAR(30) NOT NULL,
    album_annee DATE NOT NULL,
    label_id INT,
    artiste_id INT,
    PRIMARY KEY(album_id),
    CONSTRAINT fk_label FOREIGN KEY(label_id) REFERENCES label(label_id),
    CONSTRAINT fl_artiste FOREIGN KEY(artiste_id) REFERENCES artiste(artiste_id)
);

CREATE TABLE artiste_label
(
   artiste_id INT,
   label_id INT,
   PRIMARY KEY(artiste_id, label_id),
   FOREIGN KEY(artiste_id) REFERENCES artiste(artiste_id),
   FOREIGN KEY(label_id) REFERENCES label(label_id)
);

CREATE TABLE compilation_artiste
(
   compilation_id INT,
   artiste_id INT,
   PRIMARY KEY(compilation_id, artiste_id),
   FOREIGN KEY(compilation_id) REFERENCES compilation(compilation_id),
   FOREIGN KEY(artiste_id) REFERENCES artiste(artiste_id)
);

INSERT INTO artiste
(artiste_nom)
VALUES
('Dua Lipa'),
('David Guetta'),
('Loreen'),
('Inigo Quintero'),
('Teddy Swims'),
('Dadju'),
('Jason Derulo'),
('Billy Paul'),
('SANTA'),
('Francis Cabrel'),
('Ennio Morricone'),
('Piero Piccioni'),
('Goblin'),
('Riz Ortolani');

INSERT INTO  album
(album_titre, album_annee, artiste_id)
VALUES
('Santa : 999', '2022-09-09', 9),
('Billy Paul : Live in europe', '1974-12-01', 8),
('Francis Cabrel : Vise le ciel', '2012-10-22', 10);

INSERT INTO compilation
(compilation_titre, compilation_annee)
VALUES
('NRJ Hit Music Only 2024', '2024-01-01'),
('Italian Rare Groove', '1991-05-28');

INSERT INTO compilation_artiste
(compilation_id, artiste_id)
VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(2, 11),
(2, 12),
(2, 13),
(2, 14);

-- 1. Afficher tous les albums
SELECT album_titre FROM album;

-- 2. Afficher tous les artistes triés par nom et par ordre décroissant
SELECT artiste_nom
FROM artiste
ORDER BY artiste_nom;

/* 3. Afficher les compilations avec le nombre d’artistes qui y participent
SELECT compilation_titre, COUNT(artiste_id)
FROM compilation; */

-- 4. Afficher les artistes qui apparaissent dans au moins 1 album et au moins 1 compilation
SELECT artiste_nom
FROM artiste
JOIN album ON artiste.artiste_id = album.artiste_id
