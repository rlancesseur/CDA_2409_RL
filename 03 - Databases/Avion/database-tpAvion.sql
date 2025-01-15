DROP DATABASE IF EXISTS tpAvion;
CREATE DATABASE tpAvion;
USE tpAvion;

CREATE TABLE avion
(
	av INT AUTO_INCREMENT,
    avmarq VARCHAR(30) NOT NULL,
    avtype VARCHAR(10) NOT NULL,
    cap INT NOT NULL,
    loc VARCHAR(30) NOT NULL,
    PRIMARY KEY (av)
);

CREATE TABLE pilote
(
	pil INT AUTO_INCREMENT,
    pilnom VARCHAR(30),
    adr VARCHAR(30),
    PRIMARY KEY (pil)
);

CREATE TABLE vol
(
	vol VARCHAR(10),
    pil INT,
    av INT,
    vd VARCHAR(30) NOT NULL,
    va VARCHAR(30) NOT NULL,
    hd TIME NOT NULL,
    ha TIME NOT NULL,
    CONSTRAINT pk_vol PRIMARY KEY (vol),
    CONSTRAINT fk_vol_pil FOREIGN KEY (pil) REFERENCES pilote (pil),
    CONSTRAINT fk_vol_av FOREIGN KEY (av) REFERENCES avion (av)
);

INSERT INTO avion
(avmarq, avtype, cap, loc)
VALUES
('AIRBUS', 'A320', '300', 'Nice'),
('BOEING', 'B707', '250', 'Paris'),
('AIRBUS', 'A320', '300', 'Toulouse'),
('CARAVELLE', 'Caravelle', '200', 'Toulouse'),
('BOEING', 'B747', '400', 'Paris'),
('AIRBUS', 'A320', '300', 'Grenoble'),
('ATR', 'ATR42', '50', 'Paris'),
('BOEING', 'B727', '300', 'Lyon'),
('BOEING', 'B727', '300', 'Nantes'),
('AIRBUS', 'A340', '350', 'Bastia');

INSERT INTO pilote
(pilnom, adr)
VALUES
('SERGE', 'Nice'),
('JEAN', 'Paris'),
('CLAUDE', 'Grenoble'),
('ROBERT', 'Nantes'),
('SIMON', 'Paris'),
('LUCIEN', 'Toulouse'),
('BERTAND', 'Lyon'),
('HERVE', 'Bastia'),
('LUC', 'Paris');

INSERT INTO vol
(vol, pil, av, vd ,va, hd, ha)
VALUES
();

-- 1. Quels sont les vols au départ de Paris entre 12h et 14h ?

-- 2.
