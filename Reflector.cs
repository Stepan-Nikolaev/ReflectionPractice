using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReflectionPractice
{
    public class Reflector
    {
        public string GetReflectedObject<T>(T obj)
        {
            var typeObject = obj.GetType();
            var propertiesObject = typeObject.GetProperties();

            var valuesObject = propertiesObject.Select(x => $"{x.Name} : {x.GetValue(obj)}");

            string valuesObjectLine = string.Join(", ", valuesObject);

            return valuesObjectLine;
        }
    }
}
