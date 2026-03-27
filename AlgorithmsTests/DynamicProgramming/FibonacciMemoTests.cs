using Algorithms.DynamicProgramming;
using FluentAssertions;

namespace Algorithms.Tests.DynamicProgramming;

public class FibonacciMemoTests
{
    [Fact]
    public void Solve_ShouldReturnCorrectValue()
    {
        new FibonacciMemoSolver()
            .Solve(10)
            .Should().Be(55);
    }
}