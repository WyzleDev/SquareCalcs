using System;
using Xunit;
using ShapesSquareCalcs;

namespace TestSquaresCalcs
{
    public class CalcTests
    {
        [Fact]
        public void Calc_circle_square_10__314_16_returned()
        {
            float r = 10;
            float expected = 314.16f;

            CalculatorsLib calculators = new CalculatorsLib();
            float actual = calculators.CalcCircleSquare(r);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Calc_triangle_square_3_4_5__6_returned()
        {
            float x = 3;
            float y = 4;
            float z = 5;
            float expected = 6;

            CalculatorsLib calculators = new CalculatorsLib();
            float actual = calculators.CalcTriangleSquare(x, y, z);

            Assert.Equal(expected, actual);
        }
    }
}
