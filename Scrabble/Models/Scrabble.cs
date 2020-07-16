using System;
using System.Collections.Generic;


namespace Scrabble.Models
{
  public class WordCounter
  {
    #region properties
    public string UserInput { get; set; } //property // auto-implemented properties
    public int WordValue { get; set; }
    private static List<string> _words = new List<string> {};
    #endregion

    #region constructor
    public WordCounter(string userInput) //Constructor 
    {
      UserInput=userInput;
    }

    #endregion

    #region functions

    public void AddWordToList (string word)
    {
      _words.Add(word); //adds a word to our List which is named words
      Console.WriteLine("Added this word to the list:" + word);
      Console.WriteLine(word + "value is: " + WordValue);
    }

    public void PrintWords ()
    {
      foreach(string word in _words)
      {
        Console.WriteLine(word);
      }
    }

///create method to split word and check 
//Collection.Assert = compare array, lists, dictionaries
    public int LetterCounter ()
    {
      string[] arrayOfLetters = UserInput.Split("");
      Console.WriteLine("testIndex" + arrayOfLetters[1]);
      Console.WriteLine("array of letters " + arrayOfLetters); //successfully takes in word
      //Console.WriteLine("test WordValue before loop" + WordValue); // successful
      for (int i = 0; i < arrayOfLetters.Length; i++)
        {
        //Console.WriteLine("just i" + i); //doesn't work
        Console.WriteLine("arrayOfLetters[i] " + arrayOfLetters[i]);
        if (arrayOfLetters[i] == "a" )
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
