<?php

function getSum(int $A, int $B): int
{
    return $A + $B;
}


function getSub(int $A, int $B): int
{
    return $A - $B;
}


function getMulti(float $A, float $B): float
{
    return $A * $B;
}


function getDiv(int $A, int $B): int
{
    if ($B === 0) {
        return 0;
    } else {
        return round($A / $B);
    }
}
