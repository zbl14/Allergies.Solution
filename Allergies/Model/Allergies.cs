using System;
using System.Collections.Generic;

namespace AllergiesList.Modles
{
  public class Allergies
  {
    public string Allergen { get; set; }
    public int Score { get; set; }

    public Allergies(string allergen, int score)
    {
      Allergen = allergen;
      Score = score;
    }

    public static string GetAllergens(int score)
    {
      Allergies eggs = new Allergies("eggs", 1);
      Allergies peanuts = new Allergies("peanuts", 2);
      Allergies shellfish = new Allergies("shellfish", 4);
      Allergies strawerries = new Allergies("strawerries", 8);
      Allergies tomatoes = new Allergies("tomatoes", 16);
      Allergies chocolate = new Allergies("chocolate", 32);
      Allergies pollen = new Allergies("pollen", 64);
      Allergies cats = new Allergies("cats", 128);

      List<Allergies> ListOfAllergies = new List<Allergies>() { eggs, peanuts, shellfish, strawerries, tomatoes, chocolate, pollen, cats };
      int indice = score;
      string wantedallergen = "";  
      List<string> listOfResult = new List<string>(0);
      if ( indice > 256) 
      {
        return "false";
      } 
      else
      {
        while(indice >= 1)
        {
          int min = 0;
          int wanted = 0;
          foreach(Allergies allergen in ListOfAllergies)
          {
            if(allergen.Score > min && allergen.Score <= indice)
            {
              wanted = allergen.Score;
              min = allergen.Score;
              wantedallergen = allergen.Allergen;
            }
          }
          listOfResult.Insert(0, wantedallergen);
          indice -= wanted;
        }
        return String.Join(", ", listOfResult);
      }
    }
  }
}