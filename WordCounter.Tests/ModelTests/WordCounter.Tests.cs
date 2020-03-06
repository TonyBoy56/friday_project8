using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCoutner.Tests
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
    public void RepeatCounter_AcquireUserInput_String()
    {
      // Arrange //
      RepeatCounter newCounter = new RepeatCounter();
      // Act //
      string theirInput = newCounter.AcquireUserWord("word");
      // Assert //
      Assert.AreEqual("word", theirInput);
    }
  }
}
