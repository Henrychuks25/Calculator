namespace CalculatorNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {

        [Test]
        public void WhenAddingTwoNumbersReturnEqualResult()
        {
            //Arrange
            Calculator.Calculator calc = new();

            //Act
            int result = calc.AddNumbers(20, 30);

            //Assert
            Assert.That(result, Is.EqualTo(50));
        }


        [Test]
        public void WhenCheckingForOddNumberReturnTrueIfValid()
        {
            //Arrange
            Calculator.Calculator calc = new();

            //Act
            bool result = calc.IsOddNumber(3);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void WhenCheckingForOddNumberReturnFalseIfNotValid()
        {
            //Arrange
            Calculator.Calculator calc = new();

            //Act
            bool result = calc.IsOddNumber(2);

            //Assert
            Assert.That(result, Is.False);
        }
    }
}