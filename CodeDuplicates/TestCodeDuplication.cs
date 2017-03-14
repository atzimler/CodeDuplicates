using System;
using NUnit.Framework;

namespace CodeDuplicates
{
    [TestFixture]
    public class TestCodeDuplication
    {
        [Test]
        public void DivisionByZeroThrowsAnException()
        {
            var number = 42;
            var divider = 0;
            int result;

            Assert.Throws<DivideByZeroException>(() => result = number / divider);
        }

        [Test]
        public void YouShouldNotDivideANumberByZero()
        {
            var number = 13;
            var divider = 0;
            int result;

            Assert.Throws<DivideByZeroException>(() => result = number / divider);
        }
    }
}
