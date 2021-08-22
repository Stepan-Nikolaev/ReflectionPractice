using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionPractice.Models
{
    public class Figure
    {
        public string Name { get; set; }
        public int SideCount { get; set; }
        public int SideLength { get; set; }

        private string _privateProperty
        {
            get { return "Private message"; }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
