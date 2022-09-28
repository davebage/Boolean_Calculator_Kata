using Boolean_Calculator_Kata;
using NUnit.Framework;

namespace Boolean_Calculator_Kata_Tests
{
    [TestFixture]
    public class BooleanCalculator_Should
    {
        private BooleanCalculator booleanCalculator;

       [SetUp]
        public void Setup()
        {
            booleanCalculator = new BooleanCalculator();
        }

        [Test]
        [TestCase("TRUE", true)]
        [TestCase("FALSE", false)]
        [TestCase("NOT TRUE", false)]
        [TestCase("NOT FALSE", true)]
        [TestCase("TRUE AND TRUE", true)]
        [TestCase("TRUE AND FALSE", false)]
        [TestCase("FALSE AND FALSE", false)]
        [TestCase("TRUE AND TRUE AND FALSE", false)]
        [TestCase("TRUE OR TRUE", true)]
        [TestCase("FALSE OR FALSE", false)]
        [TestCase("TRUE OR FALSE", true)]
        [TestCase("TRUE OR TRUE OR TRUE AND FALSE", true)]
        [TestCase("TRUE OR FALSE AND NOT FALSE", true)]
        [TestCase("NOT TRUE AND TRUE", false)]
        [TestCase("(FALSE AND FALSE)", false)]
        [TestCase("(TRUE AND TRUE)", true)]
        [TestCase("(FALSE AND TRUE)", false)]
        [TestCase("(TRUE)", true)]
        [TestCase("((TRUE))", true)]
        [TestCase("(FALSE)", false)]
        [TestCase("((FALSE))", false)]
        [TestCase("(FALSE) OR TRUE", true)]
        public void return_expected_value_for_input(string booleanValue, bool expectedResult)
        {
            bool result = booleanCalculator.Calculate(booleanValue);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}