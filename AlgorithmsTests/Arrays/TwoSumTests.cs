using Algorithms.Arrays;
using FluentAssertions;

namespace Algorithms.Tests.Arrays;

public class TwoSumTests
{
    [Fact]
    public void Solve_ShouldReturnIndexes_WhenSolutionExists()
    {
        var solver = new TwoSumSolver();

        var result = solver.Solve(new[] { 2, 7, 11, 15 }, 9);

        result.Should().BeEquivalentTo(new[] { 0, 1 });
    }

    [Fact]
    public void Solve_ShouldThrowException_WhenNoSolution()
    {
        var solver = new TwoSumSolver();
        var nums = new[] { 1, 2, 3 };

        Assert.Throws<ArgumentException>(() => solver.Solve(nums, 10));
    }
}