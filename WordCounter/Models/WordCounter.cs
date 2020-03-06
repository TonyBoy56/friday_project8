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
  }
} 