using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Solution
{
    public class TestSolution
    {
        public static void Run()
        {
            var shapes = new List<Shape>{
                new Rectangle{Height=4,Width=6},
                new Square{Sides=3}
            };

            var areas = new List<int>();

            foreach (Shape shape in shapes)
            {
                areas.Add(shape.Area()); // This works because the implementation of the parent class can be replaced by any of it's derived classes
            }
        }
    }
}
