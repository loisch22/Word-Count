using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_Return0MatchingWords_0()
    {
      RepeatCounter newSearch = new RepeatCounter("Hello world", "Goodbye");
      int expected = 0;
      int actual = newSearch.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_Return1MatchingWord_1()
    {
      RepeatCounter newSearch = new RepeatCounter("I like dogs.", "like");
      int expected = 1;
      int actual = newSearch.CountRepeats();
      Console.WriteLine(actual);
      Assert.AreEqual(expected, actual);
    }
  }
}
