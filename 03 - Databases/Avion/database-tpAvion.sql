DROP DATABASE IF EXISTS tpAvion;
CREATE DATABASE tpAvion;
USE tpAvion;

CREATE TABLE avion
(
	av INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    avmarq VARCHAR(30) NOT NULL,
    avtype VARCHAR(10) NOT NULL,
    cap INT NOT NULL,
    loc VARCHAR(30) NOT NULL
);

ALTER TABLE avion 
AUTO_INCREMENT = 100;

CREATE TABLE pilote
(
	pil INT AUTO_INCREMENT,
    pilnom VARCHAR(30),
    adr VARCHAR(30),
    PRIMARY KEY (pil)
);

CREATE TABLE vol
(
	vol VARCHAR(10) PRIMARY KEY,
    pil INT,
    av INT UNSIGNED,
    vd VARCHAR(30) NOT NULL,
    va VARCHAR(30) NOT NULL,
    hd TINYINT NOT NULL,
    ha TINYINT NOT NULL,
    CONSTRAINT fk_vol_pil FOREIGN KEY (pil) REFERENCES pilote (pil),
    CONSTRAINT fk_vol_av FOREIGN KEY (av) REFERENCES avion (av)
);

INSERT INTO avion
(avmarq, avtype, cap, loc)
VALUES
('AIRBUS', 'A320', 300, 'Nice'),
('BOEING', 'B707', 250, 'Paris'),
('AIRBUS', 'A320', 300, 'Toulouse'),
('CARAVELLE', 'Caravelle', 200, 'Toulouse'),
('BOEING', 'B747', 400, 'Paris'),
('AIRBUS', 'A320', 300, 'Grenoble'),
('ATR', 'ATR42', 50, 'Paris'),
('BOEING', 'B727', 300, 'Lyon'),
('BOEING', 'B727', 300, 'Nantes'),
('AIRBUS', 'A340', 350, 'Bastia');

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
(vol, av, pil, vd ,va, hd, ha)
VALUES
('IT100', 100, 1, 'NICE', 'PARIS', 7, 9),
('IT101', 100, 2, 'PARIS', 'TOULOUSE', 11, 12),
('IT102', 101, 1, 'PARIS', 'NICE', 12, 14),
('IT103', 105, 3, 'GRENOBLE', 'TOULOUSE', 9, 11),
('IT104', 105, 3, 'TOULOUSE', 'GRENOBLE', 17, 19),
('IT105', 107, 7, 'LYON', 'PARIS', 6, 7),
('IT106', 109, 8, 'BASTIA', 'PARIS', 10, 13),
('IT107', 106, 9, 'PARIS', 'BRIVE', 7, 8),
('IT108', 106, 9, 'BRIVE', 'PARIS', 19, 20),
('IT109', 107, 7, 'PARIS', 'LYON', 18, 19),
('IT110', 102, 2, 'TOULOUSE', 'PARIS', 15, 16),
('IT111', 101, 4, 'NICE', 'NANTES', 17, 19),
('IT112', 103, 5, 'PARIS', 'NICE', 11, 13),
('IT113', 104, 6, 'NICE', 'PARIS', 13, 15);
