using SF.HW03.MD16.Models;

namespace SF.HW03.MD16.Tests
{
    public class CalculatorTests
    {

        [Test]
        public void AdditionalMustReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(4, 2);

            Assert.True(result == 6);
        }

        [Test]
        public void SubstractionMustReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Substraction(4, 2);

            Assert.True(result == 2);
            
        }

        [Test]
        public void MultiplicationMustReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(4, 2);

            Assert.True(result == 8);
        }

        [Test]
        public void DivisionMustReturnsCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Division(8, 2);
            
            Assert.True(result == 4);
        }
    }
}