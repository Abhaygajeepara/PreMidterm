using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace PixelCalcApp.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CalculatePPI_WithValidInput_ReturnsCorrectPPI()
        {
            // Arrange
            int width = 1920;
            int height = 1080;
            double diagonal = 24.0;
            double expectedPPI = 92.56;

            
            // Act
            double actualPPI = ;


            

            // Assert
            Assert.AreEqual(expectedPPI, actualPPI, 0.01);
        }
    }
}
