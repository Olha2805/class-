using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle 
    {
        private double sideA;
        private double sideB;

        public double GetSideA(double sideA)
        {
             return sideA;           
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
            sideA = 4;
            sideB = 3;
        }

        public double Area()
        {
            return (sideA * sideB);
        } 

        public double Perimeter()
        {
            return (sideA * 2 + sideB * 2);
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
            Rectangle rectangle = new Rectangle();
            for (int count = 0; count < n; count++)
            {
                rectangle_array[count] = rectangle;
            }
        }

        public bool AddRectangle(Rectangle[] rectangle_array, int n)
        {

            if (rectangle_array.Length < n)
            {
                Rectangle rectangle = new Rectangle();
                for (int i = 0; i < rectangle_array.Length - 1; i++)
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
            int countOfMaxArea = 0;
            double MaxArea = rectangle_array[0].Area();
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > MaxArea) MaxArea = rectangle_array[i].Area();
            }
            for (int j = 1; j < rectangle_array.Length; j++)
            {
                if (rectangle_array[j].Area() == MaxArea) countOfMaxArea++;
            }
            return countOfMaxArea;
        }

        public int NumberMinPerimeter(Rectangle[] rectangle_array)
        {
            int countOfMinPerimeter = 0;
            double MinPerimeter = rectangle_array[0].Perimeter();
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() > MinPerimeter) MinPerimeter = rectangle_array[i].Perimeter();
            }
            for (int j = 1; j < rectangle_array.Length; j++)
            {
                if (rectangle_array[j].Perimeter() == MinPerimeter) countOfMinPerimeter++;
            }
            return countOfMinPerimeter;
        }

        public int NumberSquare (Rectangle[] rectangle_array)
        {
            int countOfSquare = 0;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[0].IsSquare()) countOfSquare++;
            }           
            return countOfSquare;
        }
    }
        
}
