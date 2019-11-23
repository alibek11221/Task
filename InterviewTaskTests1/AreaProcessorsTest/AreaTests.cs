using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewTask.AreaProcessors;
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
        private IAreable Areable;
        private Triangle triangle = new Triangle(6, 9, 3);
        private Circle circle = new Circle(5);
        [TestMethod()]
        public void GetTriangleAreaTest()
        {
            //Arrange
            Areable = new TriangleArea(triangle);
            double expected = 0;
            //Act
            double actual = Areable.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsRightAngledTriangleTest()
        {
            //Arrange
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
            Areable = new CircleArea(circle);
            double expected = 78.53981633974483;
            //Act
            double actual = Areable.GetArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}