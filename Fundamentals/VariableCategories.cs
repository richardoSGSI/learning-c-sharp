using System;
using System.Collections.Generic;
using System.Text;
public enum CategoriesEnum
{
  Local,
  Static,
  Instance,
  ArrayElements,
  ValueParameters,
  ReferenceParameters,
  OutputParameters
}

namespace LearningCSharp.Fundamentals
{

  public class PublicVariableCategoriesClass
  {
    public static void RunVariableCategories()
    {
      // CategoriesEnum hello = CategoriesEnum.Local;
      // Console.WriteLine(hello);

      List<CategoriesEnum?> CategoriesList = new List<CategoriesEnum?>();
      CategoriesList.Add(CategoriesEnum.Local);
      CategoriesList.Add(CategoriesEnum.Static);
      CategoriesList.Add(CategoriesEnum.Instance);
      CategoriesList.Add(CategoriesEnum.ArrayElements);
      CategoriesList.Add(CategoriesEnum.ValueParameters);
      CategoriesList.Add(CategoriesEnum.ReferenceParameters);
      CategoriesList.Add(CategoriesEnum.OutputParameters);
      CategoriesList.Add(null);

      foreach (CategoriesEnum? category in CategoriesList)
      {
        switch (category)
        {
          case CategoriesEnum.Local:
            {
              Console.WriteLine(category);
              break;
            }
          case CategoriesEnum.Static:
            {
              Console.WriteLine(category);
              break;
            }
          case CategoriesEnum.Instance:
            {
              Console.WriteLine(category);
              break;
            }
          case CategoriesEnum.ArrayElements:
            {
              Console.WriteLine(category);
              break;
            }
          case CategoriesEnum.ValueParameters:
            {
              Console.WriteLine(category);
              break;
            }
          case CategoriesEnum.ReferenceParameters:
            {
              Console.WriteLine(category);
              break;
            }
          case CategoriesEnum.OutputParameters:
            {
              Console.WriteLine(category);
              break;
            }
          default:
            {
              throw new ArgumentException("oops");
            }
        }
      }

    }

  }
}
