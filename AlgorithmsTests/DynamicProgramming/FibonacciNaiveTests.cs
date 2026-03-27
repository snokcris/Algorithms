using Algorithms.DynamicProgramming;
using FluentAssertions;

namespace Algorithms.Tests.DynamicProgramming;

public class FibonacciNaiveTests
{
    [Fact]
    public void Solve_ShouldReturnCorrectValue_ForSmallInput()
    {
        new FibonacciNaiveSolver()
            .Solve(10)
            .Should().Be(55);
    }
}