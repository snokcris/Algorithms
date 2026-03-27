using Algorithms.DynamicProgramming;
using FluentAssertions;

namespace Algorithms.Tests.DynamicProgramming;

public class FibonacciTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    public void AllImplementations_ShouldReturnSameResult(int n, int expected)
    {
        var naive = new FibonacciNaiveSolver();
        var memo = new FibonacciMemoSolver();
        var iterative = new FibonacciIterativeSolver();

        naive.Solve(n).Should().Be(expected);
        memo.Solve(n).Should().Be(expected);
        iterative.Solve(n).Should().Be(expected);
    }
}