using System;
using System.Reflection;

namespace DateTimeReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type dateType = typeof(DateTime);
            PropertyInfo[] dateTypeProperties =  dateType.GetProperties();
            foreach(PropertyInfo property in dateTypeProperties)
            {
                Console.WriteLine($"{property.Name} - {property.PropertyType}");
            }
        }
    }
}
