using NUnit.Framework;

namespace RiderUnitTestNotDiscoveredRepro
{
    [TestFixture]
    public class SomeRandomTests
    {
        [Test]
        public void It_is_a_random_test()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}