using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpcornerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestData dataClass = new TestData();
            int add2 = dataClass.Add(45, 34, 67);
            int add1 = dataClass.Add(23, 34);
            Console.WriteLine("Add2 :" + add2);
            Console.WriteLine("Add1 :" + add1);

            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());

        }
    }
}
