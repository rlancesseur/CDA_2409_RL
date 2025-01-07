DROP DATABASE IF EXISTS rezo_social;
CREATE DATABASE rezo_social;
USE rezo_social;

CREATE TABLE utilisateur
(
	id INT,
    nom_utilisateur VARCHAR(32) NOT NULL UNIQUE,
    email VARCHAR(128) NOT NULL UNIQUE,
    PRIMARY KEY (id)
);

CREATE TABLE publication
(
	pub_id INT AUTO_INCREMENT,
    pub_date DATETIME NOT NULL,
    pub_titre VARCHAR(255),
    pub_contenu TEXT,
    id INT,
    PRIMARY KEY (pub_id)
);

CREATE TABLE aimer
(
	id INT,
	pub_id INT,
	PRIMARY KEY (id, pub_id)
);

/* MODIFIER LA TABLE PUBLICATION POUR AJOUTER LA CLE ETRANGERE */
ALTER TABLE publication
ADD FOREIGN KEY (id) REFERENCES utilisateur(id);

/* AJOUT DE LA CONTRAINTE */
ALTER TABLE aimer
	ADD CONSTRAINT fk_aimer_utilisateur FOREIGN KEY (id) REFERENCES utilisateur(id),
	ADD CONSTRAINT fk_aimer_publication FOREIGN KEY (pub_id) REFERENCES publication(pub_id);
