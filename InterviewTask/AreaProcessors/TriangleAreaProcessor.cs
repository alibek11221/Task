using InterviewTask.Shapes;
using System;
using System.Collections.Generic;
using System.Text;
using static InterviewTask.Helpers.Helper;

namespace InterviewTask.AreaProcessors
{
    public class TriangleAreaProcessor : IAreable
    {
        private Triangle _triangle;
        public TriangleAreaProcessor(Triangle triangle)
        {
            _triangle = triangle;
        }
        public double GetArea()
        {
            double halfPerimetr = GetTriangleHalfPerimetr(_triangle.SideA, _triangle.SideB, _triangle.SideC);
            double temp = (halfPerimetr - _triangle.SideA) * (halfPerimetr - _triangle.SideB) * (halfPerimetr - _triangle.SideC); 
            double SquareOfArea = halfPerimetr * temp;
            double output = Math.Sqrt(SquareOfArea);
            return output;
        }
    }
}
