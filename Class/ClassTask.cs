using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public void SetSideA(double sideA)
        {
            this.sideA = sideA;
        } 

        public double GetSideA(double sideA)
        {
             return sideA;           
        }

        public void SetSideB (double sideB)
        {
            this.sideA = sideB;
        }

        public double GetSideB (double sideB)
        {
             return sideB;
        }

        public Rectangle (double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public Rectangle (double sideA)
        {
            this.sideA = sideA;
            this.sideB = 5;
        }

        public Rectangle()
        {
            this.sideA = 4;
            this.sideB = 3;
        }

        public void Perimeter (double sideA, double sideB)
        {
            double perimeter = sideA * 2 + sideB * 2;
        }

        public void Area (double sideA, double sideB)
        {
            double area = sideA * sideB;
        }

        public bool IsSquare(double sideA, double sideB)
        {
            if (sideA == sideB) return true;
            else return false;
        }

        public void ReplaceSides(double sideA, double sideB)
        {
            sideA = sideA + sideB;
            sideB = sideA - sideB;
            sideA = sideA - sideB;
        }

    }



    //TODO: Create public class ArrayRectangles here

    //TODO: Define private field that is array of rectangles: rectangle_array

    //TODO: Define constructor with int parameter: 'n'. Constructor should create an empty array of rectangles with length of 'n'
    //TODO: Define constructor that gets enumerable or array of rectangles. Constructor should assign them to its field

    //TODO: Define public method 'AddRectangle' that adds rectangle on the first empty place of array field. Returns true if array has empty space, if not
    //TODO: Define public method 'NumberMaxArea' that returns number of rectangle with max value of area. Numbering starts from 0
    //TODO: Define public method 'NumberMinPerimeter' that returns number of rectangle with min value of perimeter. Numbering starts from 0
    //TODO: Define public method 'NumberSquare' that returns amount of squares in array of rectangles

}
