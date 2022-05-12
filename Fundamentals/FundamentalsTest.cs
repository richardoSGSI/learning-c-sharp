using System;
using System.Collections.Generic;
using System.Text;
using LearningCSharp.Fundamentals;

namespace LearningCSharp.Fundamentals
{
  internal class Test
  {
    public static void Work()
    {
      FundamentalsClass.SayHelloStatic("Richard");

      FundamentalsClass test = new FundamentalsClass();
      test.SayHelloNotStatic("Richard");
    }

    public static void InheritWork()
    {
      var test = new ClassInheritance();
      test.InheritSayHelloStatic("Richard");
    }
  }
}
