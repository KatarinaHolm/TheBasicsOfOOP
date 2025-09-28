using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _4._TheBasicsOfOOP
{
    internal class Triangle
    {
        public int BaseOfTriangle { get; set; }
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int HeightOfTriangle { get; set; }
        public int Area { get; set; }
        public int Circumference { get; set; }

        public double VolumeIfPyramid { get; set; }

        public Triangle(int baseOfTriangle, int side1, int side2, int heightOfTriangle)
        {
            BaseOfTriangle = baseOfTriangle;
            Side1 = side1;
            Side2 = side2;
            HeightOfTriangle = heightOfTriangle;
            Area = GetArea();
            Circumference = GetCircumference();
            VolumeIfPyramid = GetVolumeIfPyramid();
        }

        public int GetArea()
        {
            return (BaseOfTriangle * HeightOfTriangle) / 2;
        }
        public int GetCircumference()
        {
            return BaseOfTriangle + Side1 + Side2;
        }
        public double GetVolumeIfPyramid()
        {
            
            return Math.Round(Area * HeightOfTriangle * (1.0/3.0), 2);
        }

        public void PrintInfoOfTriangle()
        {
            Console.WriteLine($"The base of the triangle is {BaseOfTriangle} cm, and the sides are {Side1} cm and {Side2} cm.");
            Console.WriteLine($"The height is {HeightOfTriangle} cm. The area is {Area} cm² and the circumference is {Circumference} cm.");
            Console.WriteLine($"If it were a pyramid with the triangle as base, and the pyramid had same height as the height of the base triangle, the volume would be {VolumeIfPyramid} cm³. \n");

            
        }
    }
}
