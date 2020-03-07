using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string TheirWord { get; set; }
    public string TheirSentence { get; set; }

    public void Counter(string inputtedWord, string inputtedSentence)
    {
      inputtedWord = TheirWord;
      inputtedSentence = TheirSentence;
    }

    public string AcquireUserWord(string inputtedWord)
    {
      string theirInput = inputtedWord;
      return theirInput;
    }

    public string AcquireUserSentence(string inputtedSentence)
    {
      string theirInput = inputtedSentence;
      return theirInput;
    }

    public int TrackIterable(string inputtedWord, string inputtedSentence)
    {
      string theirActualWord = inputtedWord;
      string[] sentenceArray = inputtedSentence.Split(' ');
      int countTheWord = 0;
      
      foreach (string userWord in sentenceArray)
      {
        if (theirActualWord == userWord)
        {
          countTheWord ++;
        }
      }
      return countTheWord;
    }
  }
} 