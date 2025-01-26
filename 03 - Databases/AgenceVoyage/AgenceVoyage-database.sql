DROP DATABASE IF EXISTS AgenceVoyage;
CREATE DATABASE AgenceVoyage;
USE AgenceVoyage;

CREATE TABLE commercial(
   com_code VARCHAR(5),
   com_name VARCHAR(64) NOT NULL,
   com_password VARCHAR(60) NOT NULL,
   PRIMARY KEY(com_code)
);

CREATE TABLE country(
   country_code VARCHAR(2),
   country_name VARCHAR(128) NOT NULL,
   PRIMARY KEY(country_code)
);

CREATE TABLE city(
   city_code INT AUTO_INCREMENT,
   city_name VARCHAR(128) NOT NULL,
   country_code VARCHAR(2) NOT NULL,
   PRIMARY KEY(city_code),
   FOREIGN KEY(country_code) REFERENCES country(country_code)
);

CREATE TABLE trip(
   trip_code INT AUTO_INCREMENT,
   trip_title VARCHAR(128) NOT NULL,
   trip_available INT NOT NULL,
   trip_start DATETIME NOT NULL,
   trip_end DATETIME NOT NULL,
   trip_price DECIMAL(7,2) NOT NULL,
   trip_overview TEXT NOT NULL,
   trip_description TEXT,
   city_code INT NOT NULL,
   PRIMARY KEY(trip_code),
   FOREIGN KEY(city_code) REFERENCES city(city_code)
);

CREATE TABLE step(
   step_id INT AUTO_INCREMENT,
   step_start DATETIME NOT NULL,
   step_end DATETIME NOT NULL,
   city_code INT NOT NULL,
   trip_code INT NOT NULL,
   PRIMARY KEY(step_id),
   FOREIGN KEY(city_code) REFERENCES city(city_code),
   FOREIGN KEY(trip_code) REFERENCES trip(trip_code)
);

CREATE TABLE theme(
   theme_code INT AUTO_INCREMENT,
   theme_name VARCHAR(32) NOT NULL,
   theme_description TEXT,
   PRIMARY KEY(theme_code)
);

CREATE TABLE service(
   service_code INT AUTO_INCREMENT,
   service_name VARCHAR(32) NOT NULL,
   service_description TEXT,
   service_score TINYINT NOT NULL,
   service_commentaire VARCHAR(255),
   PRIMARY KEY(service_code)
);

CREATE TABLE client(
   client_id INT AUTO_INCREMENT,
   client_lastname VARCHAR(32) NOT NULL,
   client_firstname VARCHAR(32) NOT NULL,
   client_email VARCHAR(128) NOT NULL,
   client_phone VARCHAR(16) NOT NULL,
   client_added DATE NOT NULL,
   client_password VARCHAR(60) NOT NULL,
   com_code VARCHAR(5) NOT NULL,
   PRIMARY KEY(client_id),
   FOREIGN KEY(com_code) REFERENCES commercial(com_code)
);

CREATE TABLE proposer(
   trip_code INT,
   theme_code INT,
   PRIMARY KEY(trip_code, theme_code),
   FOREIGN KEY(trip_code) REFERENCES trip(trip_code),
   FOREIGN KEY(theme_code) REFERENCES theme(theme_code)
);

CREATE TABLE assurer(
   trip_code INT,
   service_code INT,
   PRIMARY KEY(trip_code, service_code),
   FOREIGN KEY(trip_code) REFERENCES trip(trip_code),
   FOREIGN KEY(service_code) REFERENCES service(service_code)
);

CREATE TABLE reserver(
   client_id INT,
   trip_code INT,
   order_quantity TINYINT NOT NULL,
   order_paid BOOLEAN,
   PRIMARY KEY(client_id, trip_code),
   FOREIGN KEY(client_id) REFERENCES client(client_id),
   FOREIGN KEY(trip_code) REFERENCES trip(trip_code)
);
