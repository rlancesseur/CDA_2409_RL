USE mini_faq;

/* Sélectionner tous les utilisateurs (identifiant, nom, prénom, email). */
SELECT user_id, user_lastname, user_firstname, user_email
FROM users;

/* Sélectionner toutes les questions (date, intitulé, réponse, identifiant utilisateur) triées par date de la plus ancienne à la plus récente. */
SELECT question_date, question_label, question_response, user_id
FROM questions
ORDER BY question_date;

/* Sélectionner les questions (identifiant, date, intitulé, réponse) de l’utilisateur n°2. */
SELECT question_id, question_date, question_label, question_response
FROM questions
WHERE user_id = 2;

/* Sélectionner les questions (date, intitulé, réponse, identifiant utilisateur) de l’utilisateur Eva Satiti. */
SELECT question_date, question_label, question_response, question_id
FROM questions
JOIN users ON users.user_firstname LIKE 'Eva' AND users.user_lastname LIKE 'Satiti';
