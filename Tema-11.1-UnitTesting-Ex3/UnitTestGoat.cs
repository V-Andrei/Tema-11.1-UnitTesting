using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema_11._1_UnitTesting_Ex3
{
    //Ex 3: Goat Latin
    [TestClass]
    public class UnitTestGoat
    {
        private GoatLatin goat;
        [TestInitialize]
        public void Setup()
        {
            goat = new GoatLatin();
        }
        [TestMethod]
        public void Should_Reverse_Goat_Language_Exemple1()
        {
            //Arrange
            string input = "I speak Goat Latin";
            string expected = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";

            //Act
            string actual = goat.ToGoatLatin(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Should_Reverse_Goat_Language_Exemple2()
        {
            //Arrange
            string input = "The quick brown fox jumped over the lazy dog";
            string expected = "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";

            //Act
            string actual = goat.ToGoatLatin(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
