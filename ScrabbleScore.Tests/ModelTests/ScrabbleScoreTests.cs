using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System.Linq;
using System.Collections.Generic;

namespace ScrabbleScore.Test
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void DisassembleWord_TurnsIntoCharArray_True()
    {
      //creatring a new instance of the Word object
      //setting a char[] called letterArray
      //newArray is a new char Array by taking the instance of word called newWor
      //bool expected returns a boolean value by running SequenceEqual which compares two char array's
      //we are then seeing if expected will be true.
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
    //checking if get word is actually retrieving the value of _userWord
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
    //checking if GetFinalScore is actually working by creating an instance and runnig it on it
    public void GetFinalScore_ConvertsToNumber_True()
    {
      //Assign
      Word newWord = new Word("a");
      //Act
      int score = newWord.GetFinalScore();
      //Assert
      Assert.AreEqual(score, 1);
    }
    [TestMethod]
    // testing get GetFinalScore on a new insatcnce with multiple char
    public void GetFinalScore_ConvertsMultiLetterWordToNumber_True()
    {
      //Assign
      Word newWord = new Word("cat");
      //Act
      int score = newWord.GetFinalScore();
      //Assert
      Assert.AreEqual(score, 5);
    }

  }
}
