using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountPotatoes.UnitTests
{
    [TestClass]
    public class PotatoesTests
    {
        [TestMethod]
        public void POTATODIFFERENCE_TOTALBAG_IS_ODD()
        {
            // Arrange
            var potatoes = new Potatoes();

            // Act
            var oddNumver = 5;
            var actual = potatoes.PotatoDifference(oddNumver);

            // Assert
            var expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void POTATODIFFERENCE_TOTALBAG_IS_EVEN()
        {
            // Arrange
            var potatoes = new Potatoes();

            // Act
            var evenNumber = 6;
            var actual = potatoes.PotatoDifference(evenNumber);

            // Assert
            var expected = 21;
            Assert.AreEqual(expected, actual);
        }
    }
}
