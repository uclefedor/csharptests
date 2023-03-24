using System;
using System.Collections.Generic;

public class Person 
{
  public string Name { get; set; }
  public bool WasNice { get; set; }
}

public class NaughtyOrNice
{
  /*search for nice people: 
  new List<Person> {
  new PersonList{ Name = "Marco", WasNice =  false} Person.wasNaughty = "Marco" => Person.WasNice == true;*/
  public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people)
  {
    List<string> result = new List<string>();
    foreach (var man in people)
    if (man.WasNice == true)
    {
      result.Add(man.Name);  
    }
    return result;
  }
  
  /*search for naughty people: 
  new List<Person> {
  new PersonList{ Name = "Marco", WasNice =  false} Person.wasNaughty = "Marco" => Person.WasNice == false;*/
  public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people)
  {
    List<string> result = new List<string>();
    foreach (var man in people)
    if (man.WasNice == false)
    {
      result.Add(man.Name); 
    }
    return result;
  }
}
