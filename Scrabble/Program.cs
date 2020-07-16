using System;
using Scrabble.Models; 

namespace Scrabble
{
  public class Program
  {
    public static void Main()//private = this function can't access it
    {

      string userInput = "apple"; //instantiating a new word
      WordCounter newCounter = new WordCounter(userInput);  //instantiating WordCounter
      newCounter.AddWordToList(userInput); //Adding words to list
      newCounter.LetterCounter();
      newCounter.PrintWords();

      // string userWord = Console.ReadLine(); 
      // newCounter.AddWordToList(userWord);
      // newCounter.PrintWords(); 

    }
  }
}
