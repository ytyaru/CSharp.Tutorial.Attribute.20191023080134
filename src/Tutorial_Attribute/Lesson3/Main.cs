using System;
using System.Reflection;

namespace Tutorial_Attribute.Lesson3
{
    public class Main
    {
        public void Run()
        {
            TypeInfo typeInfo = typeof(MyClass).GetTypeInfo();
            Console.WriteLine("The assembly qualified name of MyClass is " + typeInfo.AssemblyQualifiedName);

            var attrs = typeInfo.GetCustomAttributes();
            foreach(var attr in attrs) {Console.WriteLine("Attribute on MyClass: " + attr.GetType().Name);}
        }
    }
}
