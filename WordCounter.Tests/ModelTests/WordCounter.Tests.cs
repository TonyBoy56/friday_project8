using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void RepeatCounter_NewObjectOfClass_NewObject()
    {
      // Arrange //
      RepeatCounter newCounter = new RepeatCounter();
      // Act//
      newCounter.Counter("Hello.", "This is a test.");
      // Assert //
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType()); 
    }

    [TestMethod]
    public void AquireUserWord_RetrieveUserWord_String()
    {
      // Arrange //
      RepeatCounter newCounter = new RepeatCounter();
      // Act //
      string theirInput = newCounter.AcquireUserWord("word");
      // Assert //
      Assert.AreEqual("word", theirInput);
    }

    [TestMethod]
    public void AquireUserSentence_RetrieveUserSentence_String()
    {
      // Arrange //
      RepeatCounter newCounter = new RepeatCounter();
      // Act //
      string theirInput = newCounter.AcquireUserSentence("This is a test sentence.");
      // Assert //
      Assert.AreEqual("This is a test sentence.", theirInput);
    }

    [TestMethod]
    public void TrackIterable_FindNumberOfRepeats_Three()
    {
      // Arrange //
      RepeatCounter newCounter = new RepeatCounter();
      // Act //
      string tryThis = newCounter.TrackIterable("the", "the the");
      // Assert //
      Assert.AreEqual(2, newCounter.TrackIterable());
    }
  }
}
