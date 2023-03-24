using System;

class Kata 
{
    public static int StrCount(string str, string letter)
    {
        int count = 0;
        foreach (var s1 in str)
        {
          if (s1 == letter[0])
          {
            count++;
          }
        }
        return count;
    }
}
