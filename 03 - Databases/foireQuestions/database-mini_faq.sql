DROP DATABASE IF EXISTS mini_faq;
CREATE DATABASE mini_faq;
USE mini_faq;

CREATE TABLE users
(
	user_id INT AUTO_INCREMENT,
	user_email VARCHAR(128) NOT NULL UNIQUE,
	user_lastname VARCHAR(50) NOT NULL,
	user_firstname VARCHAR(50) NOT NULL,
    PRIMARY KEY (user_id)
);

CREATE TABLE questions
(
	question_id INT AUTO_INCREMENT,
    question_date DATETIME NOT NULL,
    question_label VARCHAR(255) NOT NULL,
    question_response TEXT NOT NULL,
    user_id INT,
    PRIMARY KEY (question_id),
    CONSTRAINT fk_questions_users FOREIGN KEY (user_id) REFERENCES users(user_id)
);

CREATE TABLE categories 
(
	category_name VARCHAR(30) NOT NULL,
    category_description VARCHAR(255),
    category_order SMALLINT NOT NULL UNIQUE,
    PRIMARY KEY (category_name)
);

CREATE TABLE categories_questions 
(
	question_id INT,
    category_name VARCHAR(30),
    PRIMARY KEY (question_id, category_name),
    FOREIGN KEY (question_id) REFERENCES questions(question_id),
    FOREIGN KEY (category_name) REFERENCES categories(category_name)
);
