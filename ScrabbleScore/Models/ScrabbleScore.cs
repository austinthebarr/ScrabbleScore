using System;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class Word
  {
    private string _userWord;
    private int _userScore;

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
      string theWord = this.GetWord();
      int theScore = 0;
      if(theWord == "a")
      {
        theScore += 1;
      }
      else
      {
        theScore += 0;
      }
      this.SetScore(theScore);
      return this.GetScore();
    }
  }
}
