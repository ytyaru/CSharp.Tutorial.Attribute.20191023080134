using System;
using System.Reflection;

namespace Tutorial_Attribute.Lesson3_0
{
    [Obsolete, SomeMessage]
    class MyClass0 {}

    [Obsolete("廃止した理由。代用クラス。")
    ,SomeMessage("なんかメッセージっすわ。")]
    class MyClass1 {}

    public class Main
    {
        public void Run()
        {
            Show(typeof(MyClass0));
            Show(typeof(MyClass1));
        }
        public void Show(Type type) {
            Console.WriteLine($"===== {type.Name} =====");
            TypeInfo typeInfo = type.GetTypeInfo();
            Console.WriteLine("The assembly qualified name of MyClass is " + typeInfo.AssemblyQualifiedName);

            var attrs = typeInfo.GetCustomAttributes();
            foreach(var attr in attrs) {Console.WriteLine("Attribute on MyClass: " + attr.GetType().Name);}
        }
    }
}
