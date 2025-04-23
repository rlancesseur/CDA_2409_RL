<?php
$error_firstname = '';

if (!empty($_POST)) {

    $firstame = $_POST["firstname"];

    if ($firstame === '') {
        $error_firstname = '<p>Le prénom est obligatoire!</p>';
    }
}
