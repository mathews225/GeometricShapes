using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quad(3, 4, 5, 6);
            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"quad1's perimeter is {perimeter}.\n");

            var quad2 = new Quad();
            Console.WriteLine($"quad2's perimeter is {quad2.GetPerimeter()}.\n");

            var rect1 = new Rect(4, 6);
            Console.WriteLine($"rect1's perimeter is {rect1.GetPerimeter()}, \nrect1's      area is {rect1.GetArea()}.\n");


            var rect2 = new Rect(5, 8);
            Console.WriteLine($"rect2's perimeter is {rect2.GetPerimeter()}, \nrect2's      area is {rect2.GetArea()}.\n");

            var sqr1 = new Sqr(5);
            Console.WriteLine($"sqr1's perimeter is {sqr1.GetPerimeter()}, \nsqr1's      area is {sqr1.GetArea()}.\n");

            var sqr2 = new Sqr(7);
            Console.WriteLine($"sqr2's perimeter is {sqr2.GetPerimeter()}, \nsqr2's      area is {sqr2.GetArea()}.\n");



        }
    }
}
