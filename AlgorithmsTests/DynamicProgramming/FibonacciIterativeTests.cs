using Algorithms.DynamicProgramming;
using FluentAssertions;

namespace Algorithms.Tests.DynamicProgramming;

public class FibonacciIterativeTests
{
    [Fact]
    public void Solve_ShouldReturnCorrectValue()
    {
        new FibonacciIterativeSolver()
            .Solve(10)
            .Should().Be(55);
    }
}