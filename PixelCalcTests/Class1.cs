using NUnit.Framework;
using PixelCalcApp;

namespace PixelCalcTests
{
    [TestFixture]
    public class PixelCalcTests
    {
        [Test]
        public void CalculatePPI_WithValidInput_ReturnsCorrectPPI()
        {
            int width = 1920;
            int height = 1080;
            double diagonal = 24.0;
            double expectedPPI = 92.56;

            double actualPPI = PixelCalc.CalculatePPI(width, height, diagonal);

            Assert.AreEqual(expectedPPI, actualPPI, 0.01);
        }

        [Test]
        public void CalculateDiagonalPixels_WithValidInput_ReturnsCorrectDiagonalPixels()
        {
            int width = 1920;
            int height = 1080;
            int expectedDiagonalPixels = 2202;

            int actualDiagonalPixels = PixelCalc.CalculateDiagonalPixels(width, height);

            Assert.AreEqual(expectedDiagonalPixels, actualDiagonalPixels);
        }

        [Test]
        public void CalculateDotPitch_WithValidInput_ReturnsCorrectDotPitch()
        {
            double ppi = 92.56;
            double expectedDotPitch = 0.0108;

            double actualDotPitch = PixelCalc.CalculateDotPitch(ppi);

            Assert.AreEqual(expectedDotPitch, actualDotPitch, 0.0001);
        }
    }
}
