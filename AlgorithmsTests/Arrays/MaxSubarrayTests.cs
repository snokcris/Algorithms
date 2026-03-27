using Algorithms.Arrays;
using FluentAssertions;

namespace Algorithms.Tests.Arrays;

public class MaxSubarrayTests
{
    [Fact]
    public void Solve_ShouldReturnMaxSum()
    {
        var solver = new MaxSubarraySolver();

        solver.Solve(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 })
              .Should().Be(6);
    }
}