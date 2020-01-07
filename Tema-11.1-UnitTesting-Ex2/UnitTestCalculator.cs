using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema_11._1_UnitTesting_Ex2
{
    //Ex 2: Calculator

    [TestClass]
    public class UnitTestCalculator
    {
        private Calculator calculator;
        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Should_Reverse_Add()
        {
            //Arrange
            int input1 = 5;
            int input2 = 6;
            int expected = 11;

            //Act
            int actual = calculator.Add(input1,input2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Should_Reverse_Sub()
        {
            //Arrange
            int input1 = 10;
            int input2 = 6;
            int expected = 4;

            //Act
            int actual = calculator.Sub(input1, input2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Should_Reverse_Mul()
        {
            //Arrange
            int input1 = 5;
            int input2 = 5;
            int expected = 25;

            //Act
            int actual = calculator.Mul(input1, input2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Should_Reverse_Div()
        {
            //Arrange
            int input1 = 25;
            int input2 = 5;
            int expected = 5;

            //Act
            int actual = calculator.Div(input1, input2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
