<?php
session_start();
$name = isset($_POST['name']) && $_POST['name'] !== "" ? $_POST['name'] : "" ;

$_SESSION['name'] = $name;

echo ucwords($name);

?>

<form action="" method="post">
<label for="name"></label>
<input type="text" id="name" name="name" value="<?php echo $name; ?>" >

<input type="submit" value="valider">

</form>

<div>
<? $name; ?>
</div>
