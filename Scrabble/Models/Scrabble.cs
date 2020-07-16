using System;
using System.Collections.Generic;


namespace Scrabble.Models
{
  public class WordCounter
  {
    #region properties
    public string UserInput { get; set; } //property // auto-implemented properties
    public int WordValue {get; set;}

    private static List<string> _words = new List<string> {};
    #endregion

    #region constructor
    public WordCounter() //Constructor 
    {

    }

    #endregion

    #region functions

    public void AddWordToList (string word)
    {
      _words.Add(word); //adds a word to our List which is named words
    }

    public void PrintWords ()
    {
      foreach(string word in _words)
      {
        Console.WriteLine(word);
      }
    }

    public int LetterCounter (string userInput, int WordValue)
    {
      string[] arrayOfLetters=userInput.Split(' ');
      for (int i = 0; i < arrayOfLetters.Length; i++)
        {
        if (i == 'a' )
        {
          WordValue +=1; 
        } 
        else
        {
          WordValue+=0; 
        }
      }
      return WordValue +=0; 
    }

    #endregion
  }
}
