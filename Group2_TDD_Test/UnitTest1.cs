using Group2_TDD.Model;

namespace Group2_TDD_Test
{
    [TestFixture]
    public class Tests
    {
        [Test(Description = "Add two number")]
        public void Add_TwoNumbers_ReturnsNumber()
        {
            //Arrange
            Calculator calculator = DefaultCalculator();

            //Act
            int result = calculator.AddNumber(0, 1);

            //Assert
            Assert.That(result, Is.EqualTo(1));

        }

        [Test(Description = "Substract two numbers")]
        public void Substract_TwoNumbers_ReturnsNumber()
        {
            //Arrange
            Calculator calculator = DefaultCalculator();

            //Act
            int result = calculator.SubstractNumber(0, 1);

            //Assert
            Assert.That(result, Is.EqualTo(-1));

        }

        [Test(Description = "Multiply two numbers")]
        public void Multiply_TwoNumbers_ReturnsNumber()
        {
            //Arrange
            Calculator calculator = DefaultCalculator();

            //Act
            int result = calculator.MultiplyNumber(0, 1);

            //Assert
            Assert.That(result, Is.EqualTo(0));

        }

        [Test(Description = "Divide two numbers")]
        public void Divide_TwoNumbers_ReturnsNumber()
        {
            //Arrange
            Calculator calculator = DefaultCalculator();

            //Act
            int result = calculator.DivideNumber(0, 1);

            //Assert
            Assert.That(result, Is.EqualTo(0));

        }


        private Calculator DefaultCalculator()
        {
            return new Calculator();
        }
    }
}
