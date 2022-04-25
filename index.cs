// C# program to find solution
// of ax + by = n
using System;
 
class GfG {
         
    // function to find the solution
    static void solution(int a, int b, int n)
    {
         
        // traverse for all possible values
        for (int i = 0; i * a <= n; i++)
        {
     
            // check if it is satisfying the
            // equation
            if ((n - (i * a)) % b == 0)
            {
                Console.Write("x = " + i +
                                ", y = " +
                        (n - (i * a)) / b);
                 
                return ;
            }
        }
     
        Console.Write("No solution");
    }
     
    // Driver code
    public static void Main ()
    {
        int a = 2, b = 3, n = 7;
        solution(a, b, n);
     
    }
}