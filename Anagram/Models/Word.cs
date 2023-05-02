using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Word
  {
    public string UserWord { get; set; }
    public static List<string> WordList = new List<string> { };

    public Word(string inputWord)
    {
        UserWord = inputWord;
        WordList.Add(this.UserWord);
    }

    
    public static List<string> GetAll()
    {
      return WordList;
    }

    public static void ClearAll()
    {
      WordList.Clear();
    }

    public static string ArraySortJoin(string word)
    {
        char[] wordArray = word.ToCharArray();
        Array.Sort(wordArray);
        string sorted = new string (wordArray);
        return sorted;
    }
  }
}