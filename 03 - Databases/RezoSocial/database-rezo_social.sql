DROP DATABASE IF EXISTS rezo_social;
CREATE DATABASE rezo_social;
USE rezo_social;

CREATE TABLE utilisateur
(
	id INT,
    nom_utilisateur VARCHAR(32),
    email VARCHAR(128),
    PRIMARY KEY (id)
);

CREATE TABLE publication
(
	pub_id INT AUTO_INCREMENT,
    pub_date DATETIME,
    pub_titre VARCHAR(255),
    pub_contenu TEXT,
    id INT,
    PRIMARY KEY (pub_id),
    FOREIGN KEY (id) REFERENCES utilisateur(id)
);

CREATE TABLE aimer
(
	id INT,
	pub_id INT,
	PRIMARY KEY (id, pub_id),
	FOREIGN KEY (id) REFERENCES utilisateur(id),
	FOREIGN KEY (pub_id) REFERENCES publication(pub_id)
);