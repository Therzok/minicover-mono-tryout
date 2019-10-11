using NUnit.Framework;
using console;

namespace nunit
{
	[TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

		[Test]
		public void Test2()
		{
			new MyClass().Instrumented();
		}
    }
}
