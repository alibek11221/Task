using InterviewTask.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Helpers
{
    public static class Helper
    {
        public static double GetTriangleHalfPerimetr(double sideA, double sideB, double sideC)
        {
            double output = (sideA + sideB + sideC) / 2;
            return output;
        }
        public static bool IsRightAngledTriangle(this Triangle triangle)
        {
            double[] sides = new double[] { triangle.SideA, triangle.SideB, triangle.SideC };
            Array.Sort(sides);
            double hypothenuse = Math.Pow(sides[0], 2);
            double summOfLegs = Math.Pow((sides[1] + sides[2]), 2);
            if (hypothenuse > summOfLegs)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
