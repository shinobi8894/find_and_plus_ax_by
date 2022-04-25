// JavaScript program to find solution
// of ax + by = n
 
    // function to find the solution
    function solution(a, b, n)
    {
        // traverse for all possible values
        for (let i = 0; i * a <= n; i++)
        {
       
            // check if it is satisfying the equation
            if ((n - (i * a)) % b == 0)
            {
                document.write("x = " + i +
                                   ", y = " +
                                   (n - (i * a)) / b);
                   
                return ;
            }
        }
       
        document.write("No solution");
    }
 
// Driver code
 
        let a = 2, b = 3, n = 7;
        solution(a, b, n);