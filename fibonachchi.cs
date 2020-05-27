using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
  while (true)
    {
      string input = Console.ReadLine();
      ulong number = ulong.Parse(input);
      ulong res = Fibonachchi.CalcFib(number);
      Console.WriteLine(res);
    }
  }
}

class Fibonachchi 
{
  public static ulong CalcFib (ulong fib) 
  {
    ulong[] fibarray = new ulong[fib];
    for(ulong i = 0; i<fib; i++)
      {
        if (i<2)
        {
          fibarray[i] = 1;
        }
        else
        {
          fibarray[i] = fibarray[i-1] + fibarray[i-2];
        }       
      }
    return fibarray[fib-1];
  }
  public static ulong CalcFibRec (ulong fib) 
  {
    ulong result = 0;
      if (fib<3)
      {
        return 1;
      }
      else
      {
        result = CalcFibRec(fib-1) + CalcFibRec(fib-2);
      }        
    return result;
  }
}
