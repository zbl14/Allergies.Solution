using System;
using Allergies.Modles;

namespace AllergiesList
{
  public class Program
  {
   public static void Main() 
   {
    Allergies eggs = new Allergies ("eggs", 1);
    Allergies peanuts = new Allergise ("peanuts", 2);
    Allergies shellfish = new Allergise ("shellfish", 4);
    Allergies strawerries = new Allergise ("strawerries", 8);
    Allergies tomatoes = new Allergise ("tomatoes", 16);
    Allergies chocolate = new Allergise ("chocolate", 32);
    Allergies pollen = new Allergise ("pollen", 64);
    Allergies cats = new Allergise ("cats", 128);

    List<Allergies> Allergies = new List<Allergies>() {eggs, peanuts, shellfish, strawerries, tomatoes, chocolate, pollen, cats}
   }
  }
}

