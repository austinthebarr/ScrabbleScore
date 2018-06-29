using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrabbleScore.Models
{
  public class Word
  {
    //Properties of the Word Object
    private string _userWord;
    private int _userScore;
    // Dictionary that has a key and a value.
    Dictionary<char, int> scoreDictionary = new Dictionary<char, int>() {
      {'a', 1}, {'e',1}, {'i',1}, {'o',1}, {'u',1}, {'l',1}, {'n',1}, {'r',1}, {'s',1}, {'t',1},
      {'d',2}, {'g',2},
      {'b',3}, {'c',3}, {'m',3}, {'p',3},
      {'f',4}, {'h',4}, {'v',4}, {'w',4}, {'y',4},
      {'k',5},
      {'j',8}, {'x',8},
      {'q',10}, {'z',10},
      };
      //Constructor for an object Word, which excepts an argument. Which would create an instance of the Word object
    public Word(string userWord)
    {
      _userWord = userWord;
      _userScore = 0;
    }
    //Getter for private property, so you can use it in another method/ or program
    public string GetWord()
    {
      return _userWord;
    }
    // setting a _userWord of the private propery of the word object
    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }
    // Getting the _userScore of the private property of the word object
    public int GetScore()
    {
      return _userScore;
    }
    // Setting the _userScore by passing an int argument
    public void SetScore(int newScore)
    {
      _userScore = newScore;
    }
    //unnececaery but getWord() from this which refers to the object Word
    //we take that word and turn it into a char Array lowercase
    //returns a lowercase char[]
    public char[] DisassembleWord()
    {
      string userWord = this.GetWord();
      char[] letterArray = userWord.ToLower().ToCharArray();
      return letterArray;
    }
    //use method DisassembleWord and run it on the object word
    //clarify thet theScore is 0
    // run a foreach loop on the char[]array, to grab each char
    // we then run for each loop on each char to find the matching char in the Dictionary, if we find a matching char, we takee the value from the key and add it to theScore
    //after we run that we take theScore and run SetScore() to set _userScore to the appropriate value.
    //then we get that value by running this.GetScore(), which grabs the score form the object word
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
      string mainInput = Console.ReadLine();
      bool input = Regex.IsMatch(mainInput, @"^[a-zA-Z]+$");
      if(input == true)
      {
        Word newWord = new Word(mainInput);
        // unnececaery
        // int userFinalScore = newWord.GetFinalScore();
        // showing the users word by running GetWord()
        // grabbing the new instacnce newWord and runnung GetFinalScore()
        Console.WriteLine("The Unmodified scrabble score of " + newWord.GetWord() + " is: " + newWord.GetFinalScore());
      }
      else{
        Console.WriteLine("Invalid: Please enter a word!!");
        Main();
      }
    }
  }
}
