using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ExtensionsMethods.Tests
{
    public class EnumerableTests
    {
        [Fact]
        public void Count()
        {
            IEnumerable<string> stringList = new List<string> { "a", "b", "c" };
            Assert.Equal(3, stringList.Count());
        }
    }
}
