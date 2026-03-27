using Algorithms.Strings;
using FluentAssertions;

namespace Algorithms.Tests.Strings;

public class LongestSubstringTests
{
    [Fact]
    public void Solve_ShouldReturnLength()
    {
        new LongestSubstringSolver()
            .Solve("abcabcbb")
            .Should().Be(3);
    }
}