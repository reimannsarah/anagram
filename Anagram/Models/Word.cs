using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Word
  {
    public string UserWord { get; set; }
    private static List<string> _wordList = new List<string> { };

    public Word(string inputWord)
    {
        UserWord = inputWord;
        _wordList.Add(this.UserWord);

    }

    
    public static List<string> GetAll()
    {
      return _wordList;
    }

    public static void ClearAll()
    {
      _wordList.Clear();
    }

    public char[] ArraySort()
    {
        char[] wordArray = this.UserWord.ToCharArray();
        Array.Sort(wordArray);
        return wordArray;
    }
  }
}