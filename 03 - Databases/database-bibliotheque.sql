DROP DATABASE IF EXISTS bibliotheque;
CREATE DATABASE IF NOT EXISTS bibliotheque;
USE bibliotheque;

CREATE TABLE IF NOT EXISTS author
(
	author_id INT AUTO_INCREMENT PRIMARY KEY,
    author_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS client
(
	client_id INT AUTO_INCREMENT PRIMARY KEY,
    client_name VARCHAR(255) NOT NULL,
    client_adress VARCHAR(255) NOT NULL,
    client_deposit SMALLINT NOT NULL
);

CREATE TABLE IF NOT EXISTS publisher
(
	publisher_id INT AUTO_INCREMENT PRIMARY KEY,
    publisher_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS book
(
	book_id INT AUTO_INCREMENT PRIMARY KEY,
    book_title VARCHAR(255) NOT NULL,
    book_purchase_date DATE NOT NULL,
    book_state VARCHAR(30) NOT NULL,
    publisher_id INT NOT NULL,
    FOREIGN KEY(publisher_id) REFERENCES publisher(publisher_id)
);

CREATE TABLE IF NOT EXISTS book_client
(
	client_id INT,
	book_id INT,
	PRIMARY KEY(client_id, book_id),
	FOREIGN KEY(client_id) REFERENCES client(client_id),
	FOREIGN KEY(book_id) REFERENCES book(book_id)

);

CREATE TABLE IF NOT EXISTS book_author(
   book_id INT,
   author_id INT,
   PRIMARY KEY(book_id, author_id),
   FOREIGN KEY(book_id) REFERENCES book(book_id),
   FOREIGN KEY(author_id) REFERENCES author(author_id)
);


INSERT INTO author
(author_name)
VALUES
('J. R. R. Tolkien'),
('J.K. Rowling');

INSERT INTO client
(client_name, client_adress, client_deposit)
VALUES
('Toto', '1 Rue de la tototerie', '10'),
('Tata', '2 Rue de Jaipasdidees', '5');

INSERT INTO publisher
(publisher_name)
VALUES
('Gallimard'),
('Flammarion');

INSERT INTO book
(book_title, book_purchase_date, book_state)
VALUES
('The Lord of the Ring', '2024-12-05', 'Good'),
('The Hobbit', '2024-05-16', 'Good'),
('Harry Potter', '2024-10-28', 'Bad');

-- SELECT book_title, book_state FROM book;
-- SELECT * FROM author;
-- SELECT client_name, client_deposit FROM client;
-- SELECT publisher_name FROM publisher;
