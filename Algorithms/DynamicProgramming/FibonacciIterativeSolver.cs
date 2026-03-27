namespace Algorithms.DynamicProgramming;

public class FibonacciIterativeSolver
{
    public int Solve(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");

        if (n <= 1)
            return n;

        int a = 0;
        int b = 1;

        for (int i = 2; i <= n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}