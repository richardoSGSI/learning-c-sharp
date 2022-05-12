using System;

namespace LearningCSharp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Fundamentals.Test.Work();
      Fundamentals.Test.InheritWork();


      var testEnums = new Fundamentals.EnumsClass();
      testEnums.EnumsSayHello("richard");
      testEnums.EnumsSayHello("richard");
      testEnums.EnumsSayHello("richard");
      testEnums.EnumsSayHello(null);

      Fundamentals.PublicVariableCategoriesClass.RunVariableCategories();
    }
  }
}
