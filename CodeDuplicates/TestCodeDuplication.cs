using System;
using NUnit.Framework;

namespace CodeDuplicates
{
    /// <summary>
    /// This is still not detected as duplicate code. I'm really bad at writing duplicated codes :D. Let's try copy paste a larger block.
    /// </summary>
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
