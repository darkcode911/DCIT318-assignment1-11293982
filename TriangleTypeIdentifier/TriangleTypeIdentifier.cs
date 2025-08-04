using System;

namespace TriangleTypeIdentifier
{
    class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("==Triangle Type Identifier==");
            Console.WriteLine("Enter sides of Triangle");

            Console.WriteLine("Enter side 1:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side 2:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side 3:");
            double side3 = Convert.ToDouble(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if(side1 == side2 && side2 == side3) 
                {
                    Console.WriteLine("This is an Equilateral Triangle");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("This is an Isoceles Triangle");
                }
                else 
                {
                    Console.WriteLine("This is a Scalene Triangle");
                }
            }
            else
            {
                Console.WriteLine("Values entered do not form a valid Triangle");
            }


        }
    }
}