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

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetSearch()
    {
      return _search;
    }

    public int GetWordCount()
    {
      return _wordCounts;
    }

    public int CountRepeats()
    {
      string searchUpper = _search.ToUpper();
      string sentenceUpper = _sentence.ToUpper();
      string[] splitSentence = sentenceUpper.Split(' ');

      for (int i = 0; i < splitSentence.Length; i++)
      {
        if (splitSentence[i].IndexOf(searchUpper) != -1)
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
