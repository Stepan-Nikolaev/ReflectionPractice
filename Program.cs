using ReflectionPractice.Models;
using System;
using System.Linq;
using System.Reflection;

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

            string figureString = reflector.GetNameObject<Figure>(figure);

            var typeFigure = Type.GetType($"ReflectionPractice.Models.{figureString}", false, true);

            var newObject = Activator.CreateInstance(typeFigure);

            var method = typeFigure.GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(x => x.Name == "DisplayMessage").First();

            String[] argumentsMethod = new string[] { "message" };

            method.Invoke(newObject, argumentsMethod);

            var privateProperties = typeFigure.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine(privateProperties[0].GetValue(newObject));
        }
    }
}
