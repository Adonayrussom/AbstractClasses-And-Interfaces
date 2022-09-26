using System;

namespace sess08_AbstractClasses_and_Interfaces
{
    /// <summary>
    /// Program demonstrating how to call/invoke methods inherited from abstract classes and interfaces
    /// </summary>
    public class DemoRightAngledTriangle
    {
        static void Main(string[] args)
        {
            RightAngledTriangle triangle = new RightAngledTriangle();
            uint[] dimensions = triangle.GetDimension();

            triangle = new RightAngledTriangle((byte)dimensions[0], (byte)dimensions[1]);

            //Display the dimensions of the right angled triangle 
            Console.WriteLine(triangle.ToString());
        }
    }
}
