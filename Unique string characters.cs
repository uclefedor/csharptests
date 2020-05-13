using System;
using System.Linq;

public static class Kata
{
  /*returns not common chars in 2 strings:
  Solve("xyab", "xzca") => "ybzc"*/
  
  public static string Solve(string a, string b)
  {
    string result = "";
    foreach (var c in a)
    {
    if (b.Contains(c) == false)
      {
        result += c;
      }
    }
    foreach (var c in b)
    {
    if (a.Contains(c) == false)
      {
        result += c;
      }
    }
    return result;
  }
}
