using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quad(3, 4, 5, 6);
            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"quad1's perimeter is {perimeter}.");
        }
    }
}
