using System;

namespace BMIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Enter your name ");
            string Name;
            Name = Console.ReadLine();

            Console.WriteLine("Enter your height (in cm):");
            double Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight (in kgw):");
            double Weight = double.Parse(Console.ReadLine());

            // algorithm
            double BMI = Weight / Math.Pow((Height / 100) , 2);

            // output
            Console.WriteLine("{0} {1}", Name, BMI);
        }
    }
}
