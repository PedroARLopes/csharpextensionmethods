using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ExtensionsMethods.Tests
{
    public class EnumerableTests
    {
        IEnumerable<string> _strings;

        public void Setup()
        {
            _strings = new List<string> { "a", "b", "c" };
        }

        [Fact]
        public void Count()
        {
            Setup();
            Assert.Equal(3, _strings.Count());
        }
    }
}
