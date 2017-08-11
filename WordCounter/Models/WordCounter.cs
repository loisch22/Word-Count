using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _search;
    private int _wordCounts = 0;

    public RepeatCounter(string sentence, string search)
    {
      _sentence = sentence;
      _search = search;
    }

    public int CountRepeats()
    {
      string[] splitSentence = _sentence.Split(' ');
      string searchWord = _search;

      for (int i = 0; i < splitSentence.Length; i++)
      {
        if (splitSentence[i] == searchWord)
        {
          _wordCounts += 1;
        }
        else
        {
          _wordCounts += 0;
        }
      }
      return _wordCounts;
    }
  }
}
