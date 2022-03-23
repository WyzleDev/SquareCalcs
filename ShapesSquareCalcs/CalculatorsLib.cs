using System;
using System.Collections.Generic;
using System.Linq;
namespace ShapesSquareCalcs
{
    public class CalculatorsLib
    {
        bool isRectangular = false;
        float square = 0f;

        public float CalcCircleSquare(float r)
        {
            square = (float)Math.Round((float)Math.PI * (float)Math.Pow(r, 2), 2);
            return square;
        }
        public float CalcTriangleSquare(float side1, float side2, float side3)
        {
            float half_perimetr = (side1 + side2 + side3) / 2;
            
            square = (float)Math.Sqrt(half_perimetr * (half_perimetr - side1) * (half_perimetr - side2) * (half_perimetr - side3));
            Console.WriteLine(isRectangular);
            return square;
        }
        private void IsRectangular(float side1, float side2, float side3)
        {
            List<float> tempList = new List<float>();
            float tempMAX = 0;

            tempList.Add(side1);
            tempList.Add(side2);
            tempList.Add(side3);

            tempMAX = tempList.Max();

            if (Math.Pow(tempMAX, 2) == (Math.Pow(tempList[0], 2) + Math.Pow(tempList[1], 2)))
            {
                isRectangular = true;
            }
            else
            {
                isRectangular = false;
            }
        }
    }
}
