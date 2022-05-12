using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Fundamentals
{
  internal class ClassInheritance : FundamentalsClass
  {
    public void InheritSayHelloStatic(string name)
    {
      SayHelloStatic($"i have inherited this method {name}. static!");
    }
  }
}
