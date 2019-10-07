using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection_HW
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Task1: ");
      DemoTask1();
      Console.WriteLine("\n\n\n\nTask 2:");
      DemoTask2();
      Console.ReadKey();
    }

    private static void DemoTask2()
    {
      Console.WriteLine("Список конструктора класса List<>:");

      var constructorsOfList = typeof(List<>).GetConstructors();

      foreach (var item in constructorsOfList)
      {
        Console.WriteLine(item);
      }
      Console.ReadLine();
    }

    static void DemoTask1()
    {
      Console.WriteLine("Введите текст:");
      string text = Console.ReadLine();

      int sizeSubstring;
      Console.WriteLine("Введите размер для Substring: ");
      string number = Console.ReadLine();
      bool isTrue = int.TryParse(number, out sizeSubstring);

      object afterSubstring = null;
      if (isTrue)
      {
        afterSubstring = text.GetType().GetMethod("Substring", new Type[] { typeof(int) }).Invoke(text, new object[] { sizeSubstring });
      }

      Console.WriteLine(afterSubstring);
    }
  }
}
