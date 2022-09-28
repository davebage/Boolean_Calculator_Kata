using Boolean_Calculator_Kata;
using NUnit.Framework;

namespace Boolean_Calculator_Kata_Tests
{
    [TestFixture]
    public class BooleanCalculator_Should
    {
        [Test]
        public void return_true_for_true()
        {
            BooleanCalculator booleanCalculator = new BooleanCalculator();

            Assert.IsTrue(booleanCalculator.Calculate("TRUE"));
        }

        [Test]
        public void return_false_for_false()
        {
            BooleanCalculator booleanCalculator = new BooleanCalculator();

            Assert.IsFalse(booleanCalculator.Calculate("FALSE"));
        }
    }
}