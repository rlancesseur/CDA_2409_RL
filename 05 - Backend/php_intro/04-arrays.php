<?php

function firstItem(array $tabName): mixed
{
    $val = '';
    if (empty($tabName)) {
        $val =  null;
    } else {
        $val =  $tabName[0];
    }
    return $val;
}

function lastItem(array $tabName): mixed
{
    $val = '';
    if (empty($tabName)) {
        $val =  null;
    } else {
        $val =  end($tabName);
    }
    return $val;
}
