using MyTestLibrary;

namespace MyCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 20;

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 20;
            double b = 10;

            // Act
            double result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 5;

            // Act
            double result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {

            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void DivideNeg_ReturnsCorrectResult()
        {

            // Arrange
            var calculator = new Calculator();
            double a = -10;
            double b = -2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void DividePosByNeg_ReturnsCorrectResult()
        {

            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = -2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void DivideByZero_ReturnsCorrectResult()
        {

            // Arrange
            var calculator = new Calculator();
            double a = 10;
            double b = 0;

            // Act
     
            try
            {
                double result = calculator.Divide(a, b);
            }
            catch (DivideByZeroException ex) {

                Assert.AreEqual("Cannot divide by zero.", ex.Message);

            }
            // Assert
            
        }
    }
}