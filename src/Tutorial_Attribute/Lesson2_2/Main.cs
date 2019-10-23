using System;

namespace Tutorial_Attribute.Lesson2_2
{
    [MyAttributeForClassAndStructOnly]
    public class MyClass0{}

    [MyAttributeForClassAndStructOnly]
    public struct MyStructure0{}

    public class MyClass1{
        // クラス、構造体以外のところで使うとエラーになる
//        [MyAttributeForClassAndStructOnly]
        public MyClass1() {}
    }
}
