using System;
using System.Collections.Generic;

public static class Kata
{
  //calculate sum of odd numbers in raw: rowSumOddNumbers(2) => 8;
    
  public static long rowSumOddNumbers(long n)
  {
    //find max value of row
    long result = 0;
    long[] temp = new long[n];
    long sum = 0;
    for (long i = 1; i<=n; i++)
    {
      sum += i;
    }
    long start = sum*2-1;    
   
   //add row to array from max to min
   int count = 0;  
   for (long i = start; i >= start-(2*(n-1)); i-=2)
    {
      temp[count] = i;
      count++;
    }
    
    //sum of raw
    foreach (var t in temp)
    {
      result += t;
    }
    return result;
  }
}
