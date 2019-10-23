using System;

namespace Tutorial_Attribute.Lesson2_0
{
// error CS0181: 属性コンストラクターのパラメーター 'myClass' には型 'Foo' がありますが、これは無効な属性パラメーター型です。
//    [Gotcha(new Foo(), "test")]
    public class Fail{}
}
