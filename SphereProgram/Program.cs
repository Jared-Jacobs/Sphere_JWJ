using System;

namespace SphereProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere = new Sphere();
            sphere.setDiameter(6.5);

            Console.WriteLine("The spheres diameter is " + sphere.getDiameter() + " inches");
            Console.WriteLine("The surface area of this sphere is " + Math.Round(sphere.getSurfaceArea(), 2) + " square inches");
            Console.WriteLine("The volume of the sphere is " + Math.Round(sphere.getVolume(), 2) + " cubic inches");
            Console.WriteLine("The shapes information: " + sphere.ToString());
        }
    }
}
