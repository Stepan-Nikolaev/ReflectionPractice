using ReflectionPractice.Models;
using System;

namespace ReflectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure() { Name = "Треугольник", SideCount = 3, SideLength = 10 };
            Reflector reflector = new Reflector();
            FileStreamer streamer = new FileStreamer();

            string reflectedFigure = reflector.GetReflectedObject<Figure>(figure);

            streamer.WriteInFile(reflectedFigure);
        }
    }
}
