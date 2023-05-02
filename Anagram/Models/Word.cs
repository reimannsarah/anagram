using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    public string UserWord { get; set; }

    public Word(string inputWord)
    {
      UserWord = inputWord;
    }
  }
}