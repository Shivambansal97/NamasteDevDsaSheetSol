using Xunit;
using LeetCodeQuesSol.String;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeQuesSol.Tests.String
{
    public class GroupAnagramSolTests
    {
        [Fact]
        public void GroupAnagrams_BasicCase()
        {
            var sol = new GroupAnagramSol();
            var input = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = sol.GroupAnagrams(input);

            var expected = new List<List<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            };
            
            Assert.True(AreEquivalent(result, expected));
        }

        [Fact]
        public void GroupAnagrams_EmptyString()
        {
            var sol = new GroupAnagramSol();
            var input = new[] { "" };
            var result = sol.GroupAnagrams(input);

            var expected = new List<List<string>>
            {
                new List<string> { "" }
            };

            Assert.True(AreEquivalent(result, expected));
        }

        [Fact]
        public void GroupAnagrams_SingleChar()
        {
            var sol = new GroupAnagramSol();
            var input = new[] { "a" };
            var result = sol.GroupAnagrams(input);

            var expected = new List<List<string>>
            {
                new List<string> { "a" }
            };

            Assert.True(AreEquivalent(result, expected));
        }

        [Fact]
        public void GroupAnagrams_MultipleEmptyStrings()
        {
            var sol = new GroupAnagramSol();
            var input = new[] { "", "", "" };
            var result = sol.GroupAnagrams(input);

            var expected = new List<List<string>>
            {
                new List<string> { "", "", "" }
            };

            Assert.True(AreEquivalent(result, expected));
        }

        [Fact]
        public void GroupAnagrams_NoAnagrams()
        {
            var sol = new GroupAnagramSol();
            var input = new[] { "abc", "def", "ghi" };
            var result = sol.GroupAnagrams(input);

            var expected = new List<List<string>>
            {
                new List<string> { "abc" },
                new List<string> { "def" },
                new List<string> { "ghi" }
            };

            Assert.True(AreEquivalent(result, expected));
        }

        private bool AreEquivalent(IList<IList<string>> actual, List<List<string>> expected)
        {
            var actualSorted = actual.Select(group => group.OrderBy(x => x).ToList()).OrderBy(g => g.FirstOrDefault()).ToList();
            var expectedSorted = expected.Select(group => group.OrderBy(x => x).ToList()).OrderBy(g => g.FirstOrDefault()).ToList();

            if (actualSorted.Count != expectedSorted.Count)
                return false;

            for (int i = 0; i < actualSorted.Count; i++)
            {
                if (!actualSorted[i].SequenceEqual(expectedSorted[i]))
                    return false;
            }
            return true;
        }
    }
}
