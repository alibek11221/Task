using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using InterviewTask.Helpers;
using InterviewTask.Shapes;

namespace InterviewTask.AreaProcessors.Tests
{
    [TestClass()]
    public class AreaTests
    {
        private IAreable _areable;
        [TestMethod()]
        public void GetTriangleAreaTest()
        {
            //Arrange
            Triangle triangle = new Triangle(6, 9, 3);
            _areable = new TriangleAreaProcessor(triangle);
            double expected = 0;
            //Act
            double actual = _areable.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsRightAngledTriangleTest()
        {
            //Arrange
            Triangle triangle = new Triangle(6, 9, 3);
            bool expected = false;
            //Act
            bool actual = triangle.IsRightAngledTriangle();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void GetCircleAreaTes()
        {
            //Arrange
            Circle circle = new Circle(5);
            _areable = new CircleAreaProcessor(circle);
            double expected = 78.53981633974483;
            //Act
            double actual = _areable.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}