using System;

namespace Tutorial_Attribute.Lesson2_1
{
    public class SomeMessageAttribute: Attribute
    {
        public SomeMessageAttribute(string message = "") {}
    }
}
