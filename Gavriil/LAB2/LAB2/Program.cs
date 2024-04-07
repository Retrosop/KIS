// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.Cryptography;


{

    Console.WriteLine("Hello, World!");

    box b = new box();
    b.InitBox(2, 3, 4);
    
    
    float var__ = b.boxV();
    Console.WriteLine(var__);
    
    
    float S = b.boxS();
    Console.WriteLine(S);

    b.Info();


    Cube c = new Cube();
    c.InitCube(75);
    c.Info();





}
public class box
{
    public float a; public float b; public float h;

    public void InitBox(float UserA, float UserB, float UserH)
    {
        a = UserA;
        b = UserB;
        h = UserH;
    }

    public float getA { get { return a; } }
    public float getB { get { return b; } }
    public float getH { get { return h; } }

    public float boxV()
    {
        float v = a * b * h;
        return v;
    }
    public float boxS()
    {
        float S = 2 * a * b + 2 * a * h + 2 * b * h;
        return S;
    }
    public void Info()
    {
        Console.WriteLine("Параллелепипед");
        string str =
            "________\n" +
            "|      |\n" +
            "|      |\n" +
            "________\n";
        Console.WriteLine(str);
        Console.WriteLine(string.Format($"A = {a}, B = {b}, H = {h}", a, b, h)); // Use indices 0, 1, 2 for a, b, h
        Console.WriteLine(string.Format($"V = {boxV()}", boxV())); // Assuming boxV() calculates volume
        Console.WriteLine(string.Format($"S = {boxS()}", boxS())); // Assuming boxS() calculates surface area
    }

}
    public class Cube
    {
        public float a;

        public void InitCube(float UserA)
        {
            a = UserA;

        }

        public float getA { get { return a; } }

        public float CubeV()
        {
            float v = a * a * a;
            return v;
        }
        public float CubeS()
        {
            float S = 6 * a * a;
            return S;
        }
        public void Info()
        {
            Console.WriteLine("Куб Вариант 2");
            string str =
                "########\n" +
                "#      #\n" +
                "#      #\n" +
                "########\n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format($"A = {a}", a));
            Console.WriteLine(string.Format($"V = {CubeV()}", CubeV()));
            Console.WriteLine(string.Format($"S = {CubeS()}", CubeS()));
        }
    }









