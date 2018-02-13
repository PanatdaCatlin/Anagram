using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void MatchedWord_CompareBreadBeard_True()
    {
      Word testWords = new Word("bread");
      Assert.AreEqual(true, testWords.CompareWord("beard"));
    }
    [TestMethod]
    public void MatchedWord_CompareChartCat_True()
    {
      Word testWords = new Word("chart");
      Assert.AreEqual(true, testWords.CompareWord("cat"));
    }
    [TestMethod]
    public void MatchedWord_ComparePathHat_True()
    {
      Word testWords = new Word("path");
      Assert.AreEqual(true, testWords.CompareWord("hat"));
    }
    [TestMethod]
    public void MatchedWord_CompareCatDog_False()
    {
      Word testWords = new Word("dog");
      Assert.AreEqual(false, testWords.CompareWord("cat"));
    }
  }
}
