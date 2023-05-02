using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Word
  {
    public string UserWord { get; set; }

    public Word(string inputWord)
    {
        UserWord = inputWord;
    }

    private static List<string> _wordList = new List<string> { };

    public void AddToList()
    {
      _wordList.Add(this.UserWord);
    }
    
    public static List<string> GetAll()
    {
      return _wordList;
    }
    
    public char[] ArraySort()
    {
        char[] wordArray = this.UserWord.ToCharArray();
        Array.Sort(wordArray);
        return wordArray;
    }
  }
}