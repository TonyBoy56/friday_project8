using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      InitializeProgram();
    }

    public static void InitializeProgram()
    {
      Console.WriteLine("Hello! Please enter a sentence. It can be as long as you may like: ");
      string inputtedSentence = Console.ReadLine();
      Console.WriteLine("Enter a word that I can use to check the sentence for: ");
      string inputtedWord = Console.ReadLine();

      RepeatCounter newCounter = new RepeatCounter();
      int iThinkThisWillWork = newCounter.TrackIterable(inputtedWord, inputtedSentence);
      Console.WriteLine(inputtedWord + " occurs " + iThinkThisWillWork + " times in the sentence you have typed.");
    }
  }
}