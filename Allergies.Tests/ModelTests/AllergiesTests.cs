using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.Tests
{
 [TestClass]
 public class AllergiesTests
 {
  [TestMethod]
  public void AllergiesTests_GetAllergens_Eggs()
  {
    int score = 1;
    Assert.AreEqual("eggs", Allergies.GetAllergens(score));
  }
  [TestMethod]
  public void AllergiesTests_GetAllergens_EggsPeanuts()
  {
    int score = 3;
    Assert.AreEqual("eggs, peanuts", Allergies.GetAllergens(score));
  }
  [TestMethod]
  public void AllergiesTests_GetAllergens_EggsStrawerries()
  {
    int score = 9;
    Assert.AreEqual("eggs, strawerries", Allergies.GetAllergens(score));
  }
 }
}