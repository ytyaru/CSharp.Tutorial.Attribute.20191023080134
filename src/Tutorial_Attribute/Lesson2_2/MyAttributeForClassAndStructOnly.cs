using System;

namespace Tutorial_Attribute.Lesson2_2
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class MyAttributeForClassAndStructOnly: Attribute {}
}
