USE agencevoyage;

INSERT INTO country
(country_code, country_name)
VALUES
("FR", "France"),
("DE", "Allemagne"),
("BE", "Belgique"),
("IT", "Italie"),
("MA", "Maroc"),
("UA", "Ukraine"),
("GB", "Ecosse");

INSERT INTO city
(city_name, country_code)
VALUES
("Paris", "FR"),
("Paris", "FR"),
("Rust", "DE"),
("Bruxelles", "BE"),
("Milan", "IT"),
("Rome", "IT"),
("Chernobyl", "UA"),
("Edimbourg", "GB"),
("Marrakesh", "MA");

INSERT INTO theme
(theme_name)
VALUES
("Montagne"),
("Plage"),
("Soleil"),
("Sports d'hiver"),
("Sports nautiques"),
("Culture"),
("Gastronomique"),
("Aventure");

INSERT INTO service
(service_name, service_score)
VALUES
("All inclusive", 0),
("Service d'étage", 1),
("Piscine", 2),
("Piscine chauffée", 3),
("Coach sportif", 4),
("Pratique du golf", 5);

INSERT INTO commercial
(com_code, com_name, com_password)
VALUES
("toto1", "Toto", "1234"),
("Tata1", "Tata", "5678"),
("Titi1", "Titi", "azerty"),
("Tutu1", "Tutu", "a1z2e3"),
("Toui1", "Touintouin", "r4t5y6");

INSERT INTO client
(client_lastname, client_firstname, client_email, client_phone, client_added, client_password, com_code)
VALUES
("nomclient1", "prenomclient1", "nomcom1.prenomcom1@blop.com", "01-02-03-04-05", "2024-10-05", "123456", "toto1"),
("nomclient2", "prenomclient2", "nomcom2.prenomcom2@blop.com", "02-03-04-05-06", "2023-11-05", "456789", "Tata1"),
("nomclient3", "prenomclient3", "nomcom3.prenomcom3@blop.com", "03-04-05-06-07", "2024-02-25", "987654", "Titi1"),
("nomclient4", "prenomclient4", "nomcom4.re@prenomcom4.com", "04-05-06-07-08", "2022-05-24", "654321", "Titi1"),
("nomclient5", "prenomclient5", "nomcom5.re@prenomcom5.com", "05-06-07-08-09", "2021-08-18", "789123", "Toui1");

INSERT INTO trip
(trip_title, trip_available, trip_start, trip_end, trip_price, trip_overview, city_code)
VALUES
("Séjour tourisitique", 1, "2025-02-20 10:00", "2025-02-27 10:00", 899, "lorem ipsum1", 5),
("Séjour Gastronomique", 2, "2025-03-20 10:00", "2025-02-25 10:00", 399, "lorem ipsum2", 1),
("Voyage Aventure", 3, "2025-04-20 10:00", "2025-02-23 10:00", 1299, "lorem ipsum3", 6),
("Destination Vert-Bouteille", 4, "2025-05-20 10:00", "2025-02-26 10:00", 849, "lorem ipsum4", 7),
("Europa Park", 5, "2025-06-20 10:00", "2025-02-22 10:00", 99, "lorem ipsum5", 3),
("Voyage desert", 2, "2025-08-20 10:00", "2025-08-30 10:00", 250, "lorem ipsum6", 9);

INSERT INTO proposer
(trip_code, theme_code)
VALUES
(1, 3),
(1, 8),
(2, 7),
(3, 8),
(4, 6),
(5, 7),
(6, 8);

INSERT INTO assurer
(trip_code, service_code)
VALUES
(1, 1),
(2, 1),
(2, 2),
(3, 5),
(3, 6),
(4, 2),
(4, 4),
(5, 1),
(5, 3);

INSERT INTO reserver
(client_id, trip_code, order_quantity)
VALUES
(2, 5, 2),
(3, 5, 5),
(3, 4, 3),
(4, 6, 5);