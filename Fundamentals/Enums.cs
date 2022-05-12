#nullable enable

using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Fundamentals
{
  public class EnumsClass
  {
    public enum Enums { Low, Medium, High };

    public void EnumsSayHello(string? name)
    {
      Enums myVar = Enums.Low;

      if (name != null)
      {
        switch (myVar)
        {
          case Enums.Low:
            Console.WriteLine($"hello {name}. Variable is Low level");
            myVar = Enums.Medium;
            break;
          case Enums.Medium:
            Console.WriteLine($"hello {name}. Variable is Medium level");
            myVar= Enums.High;
            break;
          case Enums.High:
            Console.WriteLine($"hello {name}. Variable is High level");
            break;
          default:
            myVar = Enums.High;
            break;
        }
      }
      else
      {
        Console.WriteLine($"please fill in a name instead of {name}");
      }
    }

  }
}
