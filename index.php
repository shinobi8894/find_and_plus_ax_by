<?php
// PHP program to find
// solution of ax + by = n
 
// function to find the solution
function solution($a, $b, $n)
{
    // traverse for all possible values
    for ($i = 0; $i * $a <= $n; $i++)
    {
 
        // check if it is satisfying
        // the equation
        if (($n - ($i * $a)) % $b == 0)
        {
            echo "x = " , $i , ", y = " ,
                   ($n - ($i * $a)) / $b;
            return;
        }
    }
 
    echo "No solution";
}
 
// Driver Code
$a = 2; $b = 3; $n = 7;
solution($a, $b, $n);
 
?>