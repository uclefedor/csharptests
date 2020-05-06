using System;

public class Kata
{
  public static string GetDrinkByProfession(string p)
  {
    string drink = "";
    string upperinput = p.ToUpper();
    switch (upperinput)
    {
      case "JABRONI":
            drink = "Patron Tequila";
            break;
      case "SCHOOL COUNSELOR":
            drink = "Anything with Alcohol";
            break;
      case "PROGRAMMER":
            drink =  "Hipster Craft Beer";
            break;
      case "BIKE GANG MEMBER":
            drink = "Moonshine";
            break;
      case "POLITICIAN":
            drink = "Your tax dollars";
            break;
      case "RAPPER":
            drink = "Cristal";
            break;
      default:
            drink = "Beer";
            break;
    }  
    return drink;
  }
}
