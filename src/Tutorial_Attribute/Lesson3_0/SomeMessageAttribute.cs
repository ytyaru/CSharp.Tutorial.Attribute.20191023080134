using System;

namespace Tutorial_Attribute.Lesson3_0
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class SomeMessageAttribute: Attribute
    {
        public SomeMessageAttribute(string message = "") {}
    }
}
