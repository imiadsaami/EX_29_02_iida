using System;

namespace Ex_29_02_iida
{
    public class Program
    {
        static void Main()
        {
            float value, value1, value2;
            Console.WriteLine("円柱");
            value = Input("底面の半径を入力してください");
            value1 = Input("高さを入力してください");
            Console.WriteLine("表面積 = " + Cylinder.GetSurface(value, value1));
            Console.WriteLine("体積 = " + Cylinder.GetVolume(value, value1));

            Console.WriteLine("\n球");
            value = Input("半径を入力して下さい");
            Console.WriteLine("表面積 = " + Sphere.GetSurface(value));
            Console.WriteLine("体積 = " + Sphere.GetVolume(value));

            Console.WriteLine("\n三角柱");
            value = Input("底面の底辺を入力して下さい");
            value1 = Input("底面の高さを入力して下さい");
            value2 = Input("高さを入力して下さい");
            Console.WriteLine("表面積 = " + TriangularPrism.GetSurface(value, value1, value2));
            Console.WriteLine("体積 = " + TriangularPrism.GetVolume(value, value1, value2));
        }

        static float Input(string outputString)
        {
            float input;
            while (true)
            {
                Console.WriteLine(outputString);
                if (float.TryParse(Console.ReadLine(), out input))
                {
                    return input;
                }
            }
        }
    }

    static class Cylinder
    {
        static public float GetSurface(float bottom, float height)
        {
            return bottom * 2.0f * (float)Math.PI * height + bottom * bottom * (float)Math.PI * 2.0f;
        }
        static public float GetVolume(float bottom, float height)
        {
            return bottom * bottom * (float)Math.PI * height;
        }
    }

    static class Sphere
    {
        static public float GetSurface(float radius)
        {
            return 4.0f * (float)Math.PI * radius * radius;
        }
        static public float GetVolume(float radius)
        {
            return (4.0f / 3.0f) * (float)Math.PI * radius * radius * radius;
        }
    }

    static class TriangularPrism
    {
        static public double GetSurface(float bottom, float bottomHeight, float height)
        {
            return bottom * bottomHeight + (bottom + bottomHeight + Math.Sqrt(bottom * bottom + bottomHeight * bottomHeight)) * height;
        }
        static public float GetVolume(float bottom, float bottomHeight, float height)
        {
            return bottom * bottomHeight / 2.0f * height;
        }
    }
}