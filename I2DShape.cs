using System;

namespace sess08_AbstractClasses_and_Interfaces
{
    /// <summary>
    /// Interface that all 2 dimensional shapes must implement in order to calculate their 
    /// perimeter or circumference
    /// </summary>
    public interface I2DShape
    {
        float CalcPerimeter();

        float CalcCircumference(int radius);
        //The code below is supported/valid in newer .NET version(C# 8.0 upwards)

        //loat CalcCircumference(int radius)
        //{
        //return ((float)(Math.PI * (radius * 2));
        //}


    }
}
