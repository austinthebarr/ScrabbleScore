using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Test
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void GetScore_ConvertsToNumber_True()
      {
        //Assign
        Word newWord = new Word("a");
        //Act
        int score = newWord.GetFinalScore();
        //Assert
        Assert.AreEqual(score, 1);
      }
  }
}
