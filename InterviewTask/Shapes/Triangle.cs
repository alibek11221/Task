﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Shapes
{
    public class Triangle 
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB >= sideC &&  sideA + sideC >= sideB && sideB + sideC >= sideA)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new Exception("Triangle does not exist");
            }

        }
    }
}
