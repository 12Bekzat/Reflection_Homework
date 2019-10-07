using System;

namespace Reflection_HW
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите текст:");
      string text = Console.ReadLine();

      int sizeSubstring;
      Console.WriteLine("Введите размер для Substring: ");
      string number = Console.ReadLine();
      Int32.TryParse(number, out sizeSubstring);

      var afterSubstring = text.GetType().GetMethod("Method: Substring", new[] { typeof(int) }).Invoke(text, new object[] { sizeSubstring });

      Console.WriteLine(afterSubstring);
      Console.ReadKey();
    }
  }
}
