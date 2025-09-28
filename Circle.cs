using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._TheBasicsOfOOP
{
    public class Circle
    {
        //Field
        private int _radius;

        //Properties
        public int Radius { get; set;}
        public double Area { get; set; }
        public double Circumference { get; set; }

        public double VolumeIfSphere { get; set; }

        //Constructor
        public Circle(int radiusInput)
        {
            Radius = radiusInput;
            Area = GetArea();
            Circumference = GetCircumference();
            VolumeIfSphere = GetVolumeIfSphere();
        }

        //Methods
        public double GetArea()
        {
            return Math.Round(Radius * Radius * Math.PI, 2);
        }

        public double GetCircumference()
        {
            return Math.Round(2 * Radius * Math.PI, 2);
        }

        public double GetVolumeIfSphere()
        {
            return Math.Round((4.0 / 3.0) * Math.Pow(Radius, 3) * Math.PI , 2);
        }

        public void PrintInfoOfCircle()
        {
            Console.WriteLine($"The radius of the circle is {Radius} cm, the area is {Area} cm² and the circumference is {Circumference} cm.");
            Console.WriteLine($"If it had been a sphere the volume would have been {VolumeIfSphere} cm³.\n");
        }
    }
}
