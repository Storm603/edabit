using System;

namespace T01._Make_A_Circle_With_OOP
{

    class Program
    {

        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            Circle circly = new Circle(radius);

            Console.WriteLine(circly.GetPerimeter());
            
        }
    }
}
