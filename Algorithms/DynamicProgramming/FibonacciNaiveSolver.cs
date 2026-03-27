namespace Algorithms.DynamicProgramming;

public class FibonacciNaiveSolver
{
    public int Solve(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");

        if (n <= 1)
            return n;

        return Solve(n - 1) + Solve(n - 2);
    }
}