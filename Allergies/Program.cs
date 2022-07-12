using System;
using AllergiesList.Modles;

namespace AllergiesList
{
  public class Program
  {
   public static void Main() 
   {
    Console.WriteLine("What is your score of the allergies test?");
    int score = int.Parse(Console.ReadLine());
    Console.WriteLine(Allergies.GetAllergens(score));
   }
  }
}
