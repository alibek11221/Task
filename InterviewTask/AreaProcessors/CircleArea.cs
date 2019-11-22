using InterviewTask.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.AreaProcessors
{
    public class CircleArea : IAreable
    {
        private Circle _circle;

        public CircleArea(Circle circle)
        {
            _circle = circle;
        }

        public double GetArea()
        {
            double output = Math.PI * Math.Pow(_circle.Radius, 2);
            return output;
        }
    }
}
