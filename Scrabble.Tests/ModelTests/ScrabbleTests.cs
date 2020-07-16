using System;
using System.Collections.Generic;  
using Scrabble.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace Scrabble.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void WordCounterConstructor_CreatesInstanceOfWordCounter_WordCounter()
    {
      WordCounter newWord = new WordCounter("test");
      Assert.AreEqual(typeof(WordCounter), newWord.GetType());
    }

    [TestMethod]
    public void WordCounter_ReturnsWord_String()
    {
      string userInput = "Rabbit";
      WordCounter newWordCounter = new WordCounter(userInput);
      string result = newWordCounter.UserInput;
      Assert.AreEqual(userInput, result);
    }

    [TestMethod]
    public void WordCounterLetterCounter_AddsValueofLetters_Int()
    {
      string userInput = "Rabbit";
      WordCounter newCounter = new WordCounter(userInput);
      int valueResult = newCounter.LetterCounter(userInput); 
      Assert.AreEqual(1, valueResult);
    }

  }
}