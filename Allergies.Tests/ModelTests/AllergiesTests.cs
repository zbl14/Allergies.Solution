using Microsoft.VisualStudio.TestTools.UnitTesting;
// using AllergiesList.Modles;

namespace Allergies.Tests
{
 [TestClass]
 public class AllergiesTests
 {
  [TestMethod]
  public void AllergiesTests_GetAllergens_Eggs()
  {
    int score = 1;
    Assert.AreEqual("eggs", AllergiesList.Modles.Allergies.GetAllergens(score));
  }
  [TestMethod]
  public void AllergiesTests_GetAllergens_EggsPeanuts()
  {
    int score = 3;
    Assert.AreEqual("eggs, peanuts", AllergiesList.Modles.Allergies.GetAllergens(score));
  }
  [TestMethod]
  public void AllergiesTests_GetAllergens_EggsStrawerries()
  {
    int score = 9;
    Assert.AreEqual("eggs, strawerries", AllergiesList.Modles.Allergies.GetAllergens(score));
  }
  [TestMethod]
  public void AllergiesTests_GetAllergens_False()
  {
    int score = 257;
    Assert.AreEqual("false", AllergiesList.Modles.Allergies.GetAllergens(score));
  }
 }
}