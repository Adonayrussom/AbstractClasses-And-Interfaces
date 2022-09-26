using System;

namespace sess08_AbstractClasses_and_Interfaces
{
    //Class demonstrating how to inherit from an abstract class and implement an interface.This class will be used
    public class RightAngledTriangle : Triangle, I2DShape
    {
        //Instance variables/fields
        private uint height;
        private uint @base;
        private uint hypotenuse;

        public RightAngledTriangle()
        {
            this.height = 0;
            this.@base = 0;
            this.hypotenuse = 0;
        }

        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            this.hypotenuse = (byte)(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(@base, 2)));
        }

        public override float CalcArea()
        {
            return (float)(.5 * this.height * this.@base);
        }

        public float CalcCircumference(int radius)
        {
            return 0.0f;
        }

        public float CalcPerimeter()
        {
            return (this.height + this.@base + this.hypotenuse);
        }

        public override uint[] GetDimension()
        {
            uint[] dimensions = new uint[2];

            //Prompt the user for the triangle's base and height
            Console.WriteLine(@"Please enter the triangle's height in cm -> ");
            dimensions[0] = uint.Parse(Console.ReadLine());

            Console.WriteLine(@"Please enter the triangle's base in cm -> ");
            dimensions[1] = uint.Parse(Console.ReadLine());

            return dimensions;
        }

        public override string ToString()
        {
            return ($"The values of the right angled triangle are\n"
                     + $"\n--------------------------------------"
                    + $"\nbase:  {this.@base}"
                    + $"\nHeight: + {this.height}"
                    + $"\nHypotenuse: {this.hypotenuse}"
                    + $"\nPerimeter: {this.CalcPerimeter()}"
                    + $"\nArea: {this.CalcArea()}"
                    + $"\n-----------------------------------------\n");
        }
    }
}
