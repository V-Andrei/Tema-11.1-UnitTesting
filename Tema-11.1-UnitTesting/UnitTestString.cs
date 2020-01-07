using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema_11._1_UnitTesting
{
    //Ex 1: Strings problem
    [TestClass]
    public class UnitTestString
    {
        private StringsUtils reverse;
        [TestInitialize]
        public void Setup()
        {
            reverse = new StringsUtils();
        }

        [TestMethod]
        public void Should_Reverse_Valid_String_Exemple1()
        {
            //Arrange
            string input = "abcd";
            string expected = "dcba";

            //Act
            string actual = reverse.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Reverse_Valid_String_Exemple2()
        {
            //Arrange
            string input = "a-bC-dEf-ghIj";
            string expected = "j-Ih-gfE-dCba";

            //Act
            string actual = reverse.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Throw_Exception_When_Null_Exemple3()
        {
            //Arrange
            string input = null;

            //Act
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => reverse.Reverse(input));

        }
        [TestMethod]
        public void Should_Reverse_Valid_String_Exemple4()
        {
            //Arrange
            string input = "Test1ng-Leet=code-Q!";
            string expected = "Qedo1ct-eeLg=ntse-T!";

            //Act
            string actual = reverse.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
