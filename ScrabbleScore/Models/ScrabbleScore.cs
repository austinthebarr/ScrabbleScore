using System;
using System.Linq;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Word
  {
    private string _userWord;
    private int _userScore;
    Dictionary<char, int> scoreDictionary = new Dictionary<char, int>() {
      {'a', 1}, {'e',1}, {'i',1}, {'o',1}, {'u',1}, {'l',1}, {'n',1}, {'r',1}, {'s',1}, {'t',1},
      {'d',2}, {'g',2},
      {'b',3}, {'c',3}, {'m',3}, {'p',3},
      {'f',4}, {'h',4}, {'v',4}, {'w',4}, {'y',4},
      {'k',5},
      {'j',8}, {'x',8},
      {'q',10}, {'z',10},
      };

    public Word(string userWord)
    {
      _userWord = userWord;
      _userScore = 0;
    }
    public string GetWord()
    {
      return _userWord;
    }
    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }
    public int GetScore()
    {
      return _userScore;
    }
    public void SetScore(int newScore)
    {
      _userScore = newScore;
    }
    public char[] DisassembleWord()
    {
      string userWord = this.GetWord();
      char[] letterArray = userWord.ToLower().ToCharArray();
      return letterArray;
    }
    public int GetFinalScore()
    {
      char[] letterArray = this.DisassembleWord();
      int theScore = 0;

      foreach(char letter in letterArray)
      {
        foreach(KeyValuePair<char, int> scores in scoreDictionary)
        {
          if(letter == scores.Key)
          {
            theScore += scores.Value;
          }
        }
      }
      this.SetScore(theScore);
      return this.GetScore();
    }
    //End Word Class
  }
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a single word to find its unmodified scrabble value:");
      Word newWord = new Word(Console.ReadLine());
      int userFinalScore = newWord.GetFinalScore();
      Console.WriteLine("The Unmodified scrabble score of " + newWord.GetWord() + " is: " + userFinalScore);
    }
  }
}
