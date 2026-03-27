namespace Algorithms.DynamicProgramming;

public class FibonacciMemoSolver
{
    private readonly Dictionary<int, int> _memo = new();

    public int Solve(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");

        if (n <= 1)
            return n;

        if (_memo.ContainsKey(n))
            return _memo[n];

        var result = Solve(n - 1) + Solve(n - 2);

        _memo[n] = result;
        return result;
    }
}