using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle 
    {
         private double sideA;
         private double sideB;

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public Rectangle (double a)
        {
            sideA = a;
            this.sideB = 5;
        }

        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }
        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideA * sideB;
        } 

        public double Perimeter()
        {
            return sideA * 2 + sideB * 2;
        }

        public bool IsSquare()
        {
            if (sideA == sideB) return true;
            else return false;
        }

        public void ReplaceSides()
        {
            sideA = sideA + sideB;
            sideB = sideA - sideB;
            sideA = sideA - sideB;
        }
    }

    public class ArrayRectangles
    {

        private Rectangle[] rectangle_array;    

        public ArrayRectangles(int n)
        {            
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(params Rectangle[] rectangle_array1)
        {
            rectangle_array = new Rectangle[rectangle_array1.Length];
            Array.Copy(rectangle_array1, rectangle_array, rectangle_array1.Length);
        }
        public bool AddRectangle(Rectangle[] rectangle_array, int n)
        {

            if (rectangle_array.Length < n)
            {
                Rectangle rectangle = new Rectangle();
                for (int i = 0; i < rectangle_array.Length; i++)
                {
                    rectangle_array[i] = rectangle_array[i + 1];
                    rectangle_array[0] = rectangle;
                }
                return true;
            }
            else return false;
        }

        public int NumberMaxArea(Rectangle[] rectangle_array)
        {
            int numberOfMaxArea = 0;
            double MaxArea = rectangle_array[0].Area();
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > MaxArea) MaxArea = rectangle_array[i].Area();
                numberOfMaxArea = i;
            }
            return numberOfMaxArea;
        }

        public int NumberMinPerimeter(Rectangle[] rectangle_array)
        {
            int numberOfMinPerimeter = 0;
            double MinPerimeter = rectangle_array[0].Perimeter();
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() > MinPerimeter) MinPerimeter = rectangle_array[i].Perimeter();
                numberOfMinPerimeter = i;
            }
            return numberOfMinPerimeter;
        }

        public int NumberSquare(Rectangle[] rectangle_array)
        {
            int countOfSquare = 0;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].IsSquare()) countOfSquare++;
            }
            return countOfSquare;
        }
    }
}
