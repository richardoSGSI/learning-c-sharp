using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Fundamentals
{
  public class FundamentalsClass
  {
    public static void SayHelloStatic(string name)
    {
      Console.WriteLine($"hello {name}. this is static");
    }

    public void SayHelloNotStatic(string name)
    {
      Console.WriteLine($"hello {name}. this is NOT static");
    }
  }
}
