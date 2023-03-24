using System;

public class Kata 
{
  public static string SplitInParts(string s, int partLength)
  {  
 //declare variables
 
    string newString = "";
    string temp = "";
    int size = 0;
    string tail = "";
  
 //size of array + tail 
   
    if (s.Length<=partLength)
      {
        newString = s;
      }
    if (s.Length%partLength != 0)
      {
        size = s.Length/partLength + 1;
        int indexOfTail = s.Length - s.Length%partLength;
        tail = s.Substring(indexOfTail);
      }
    else
      {
       size = s.Length/partLength; 
      }
    if (s.Length<=partLength)
      {
        newString = s;
        Console.WriteLine(size);
      }
   
  //create new result string
    
    string[] sArr = new string[size];
    int count = 0;
    {
      for (int i = 0; i<=s.Length-partLength; i+=partLength)
      {
        temp = s.Substring(i, partLength);
        sArr[count] = temp;
        count++;
      }
    }
    newString = String.Join(" ", sArr);
    return newString + tail;    
  }
}  
