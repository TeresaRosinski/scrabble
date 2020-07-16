using System;
using Scrabble.Models; 

namespace Scrabble
{
  public class Program
  {
    public static void Main()//private = this function can't access it
    {
      string newWord = "apple"; //instantiating a new word
      WordCounter newCounter = new WordCounter();  //instantiating WordCounter
      newCounter.AddWordToList(newWord); //Adding words to list
      newCounter.PrintWords();

      userWord = Console.ReadLine(); 
      
    }
  }
}
