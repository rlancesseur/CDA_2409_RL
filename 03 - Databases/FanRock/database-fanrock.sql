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

CREATE TABLE IF NOT EXISTS album
(
	album_id INT AUTO_INCREMENT PRIMARY KEY,
    album_titre VARCHAR(30) NOT NULL,
    album_annee DATE NOT NULL,
    artiste_id INT NOT NULL,
    FOREIGN KEY(artiste_id) REFERENCES artiste(artiste_id)
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
('Francis Cabrel');

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

-- SELECT album_titre FROM album;
-- SELECT artiste_nom FROM artiste ORDER BY artiste_nom ASC;

