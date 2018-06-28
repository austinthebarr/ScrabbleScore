using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System.Linq;

namespace ScrabbleScore.Test
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void DisassembleWord_TurnsIntoCharArray_True()
    {
      //Assign
      Word newWord = new Word("cat");
      char[] letterArray = {'c', 'a', 't'};
      //Act
      char[] newArray = newWord.DisassembleWord();
      bool expected = newArray.SequenceEqual(letterArray);
      //Assert
      Assert.AreEqual(expected, true);
    }
    [TestMethod]
    public void GetWord_FromSettingWord_True()
    {
      //Assign
      Word newWord = new Word("a");

      //Act
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(result, "a");
    }

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
