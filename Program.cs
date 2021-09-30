using System;

namespace Operators_exercise_2
{
    public class AreaOfCircle
    {
        public static void Main(string[] args)
        {
            Console.Write("What is the radius of your circle?");

            double radius = double.Parse(Console.ReadLine());

            double AreaOfCircle = (_ = Math.PI * radius * radius);

            Console.WriteLine("Area Of Circle:" + AreaOfCircle);
        }

        public static double Calculate(double variable)
        {
            Console.Write("What is the radius of your circle?");

            double radius = double.Parse(Console.ReadLine());

            double AreaOfCircle = (_ = Math.PI * radius * radius);

            Console.WriteLine("Area Of Circle:" + AreaOfCircle);
            return AreaOfCircle;


        }



    }
}

