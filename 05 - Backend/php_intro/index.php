<?php
require "01-hello.php";
require "02-numbers.php";
require "03-strings.php";
require "traitement.php";
?>

<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercices intro</title>
</head>

<body>
    <div class="testFunction">
        <p>Function helloWorld : <?php helloWorld() ?></p>
        <p>Function hello : <?= hello("Rémi") ?></p>
        <p>Function getSum : <?= getSum(5, 3) ?></p>
        <p>Function getSub : <?= getSub(5, 3) ?></p>
        <p>Function getMulti : <?= getMulti(5.6, 3) ?></p>
        <p>Function getDiv : <?= getDiv(20, 3) ?></p>
        <p>Function getMC2 : <?= getMC2() ?></p>
        <p>Function getUserName : <?= getUserName("Rémi", "Lancesseur") ?></p>
        <p>Function getFullName : <?= getFullName("REMI", "lancesseur") ?></p>
        <p>Function askUser : <?= askUser("Rémi", "Lancesseur"); ?></p>

        <p>Function capitalCity : <?= capitalCity("Suède") ?></p>
        <p>Function capitalCity : <?= capitalCity("Paris", false) ?></p>
    </div>

    <form method="post">
        <div>
            <?php
            if ($error_firstname !== '') echo $error_firstname;
            ?>
            <label for="firstname">Prénom</label>
            <input type="text" name="firstname" id="firstname">
        </div>
        <div>
            <label for="lastname">Nom</label>
            <input type="text" name="lastname" id="lastname">
        </div>
        <input type="submit" value="Ajouter">
    </form>

</body>

</html>