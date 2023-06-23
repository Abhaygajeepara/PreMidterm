using NUnit.Framework;
using System;

namespace PixelCalcTests
{
    [TestFixture]
    public class PixelCalcTests
    {
        

        

        [Test]
        public void CalculateDiagonalPixels_WithValidInput100_100_ReturnsCorrectDiagonalPixels() {
            // arrang
            int width = 100;
            int height = 100;
            int expectedDiagonalPixels = 141;
            // Act
            int actualDiagonalPixels = PixelCalc.CalculateDiagonalPixels(width, height);
            // Assert

            Assert.AreEqual(expectedDiagonalPixels, actualDiagonalPixels);
        }

        [Test]
        public void CalculatePPI_WithValidInput_100_100_5_ReturnsCorrectCalculatePPI()
        {
            // arrang
            int width = 100;
            int height = 100;
            int diagonal = 5;
            double expectedppi = 28.28;
            // Act
            double actualPPI= PixelCalc.CalculatePPI(width, height,diagonal);
            // Assert

            Assert.AreEqual(expectedppi, actualPPI);
        }
        [Test]
       
        public void CalculatePPI_WithValidInput_450_600_6_ReturnsCorrectCalculatePPI()
        {
            // arrang
            int width = 450;
            int height = 600;
            int diagonal = 6;
            double expectedppi = 125;
            // Act
            double actualPPI = PixelCalc.CalculatePPI(width, height, diagonal);
            // Assert

            Assert.AreEqual(expectedppi, actualPPI);
        }
        [Test]
        public void CalculateDiagonalPixels_WithValidInput450_600_ReturnsCorrectDiagonalPixels()
        {
            // arrang
            int width = 450;
            int height = 600;
            int expectedDiagonalPixels = 750;
            // Act
            int actualDiagonalPixels = PixelCalc.CalculateDiagonalPixels(width, height);
            // Assert

            Assert.AreEqual(expectedDiagonalPixels, actualDiagonalPixels);
        }
        [Test]
        public void CalculateDiagonalPixels_WithValidInput2160_1080_ReturnsCorrectDiagonalPixels()
        {
            // arrang
            int width = 2160;
            int height = 1080;
            int expectedDiagonalPixels = 2414;
            // Act
            int actualDiagonalPixels = PixelCalc.CalculateDiagonalPixels(width, height);
            // Assert

            Assert.AreEqual(expectedDiagonalPixels, actualDiagonalPixels);
        }

        [Test]
        public void CalculateDotPitch_WithValidInput_ReturnsCorrectDotPitch()
        {
            // arrang
            double expectedDotpitch = 0.04;
            double PPI = 28.28;

            // Act
            double actualDotpitch = PixelCalc.CalculateDotPitch(PPI);
            // Assert

            Assert.AreEqual(expectedDotpitch, actualDotpitch);
        }





    }
}
