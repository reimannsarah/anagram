using System;
using Anagram.Models;
using Anagram.UserInterfaceModels;

namespace Anagram
{
  class Program
  {
    static void Main()
    {
      PlayTheGame();
    }

    static void PlayTheGame()
    {
      Console.WriteLine("WELCOME TO:");
      Console.WriteLine($"{WelcomeBanner.Welcome}");
      Console.WriteLine("Please enter your reference word");
      string userInput = Console.ReadLine();
      Word newWord = new Word(userInput);
      AddMoreWords();
    }

    static void AddMoreWords()
    {
      Console.WriteLine("Please enter a word you think is an anagram");
      string userInput = Console.ReadLine();
      Word newWord = new Word(userInput);
      // newWord.AddToList();
      Console.WriteLine($"Here is your reference word: {Word.WordList[0]}");
      Console.WriteLine($"Here is/are your potential anagram(s):");
      ShowWordList();
      Console.WriteLine("Would you like to test another word?");
      Console.WriteLine("type 'yes' if you'd like to test more words, 'test' if you're ready to analyze your anagram(s)");
      string YesOrNo = Console.ReadLine();
      if (YesOrNo == "yes")
      {
        AddMoreWords();
      }
      else
      {
        CompareWords();
      }
    }

    static void ShowWordList()
    {
      for (int i = 1; i < Word.WordList.Count; i++)
      {
        Console.WriteLine($"{Word.WordList[i]}");
      }
    }
    static void CompareWords()
    {
      string refString = Word.ArraySortJoin(Word.WordList[0]);
      for (int i = 1; i < Word.WordList.Count; i++)
      {
        string compareString = Word.ArraySortJoin(Word.WordList[i]);
        if (compareString == refString)
        {
          Console.WriteLine($"{Word.WordList[i]} is an anagram of {Word.WordList[0]}!");
        }
        else
        {
          Console.WriteLine($"{Word.WordList[i]} is not an anagram of {Word.WordList[0]}, idiot ;)");
        }
      }
      Console.WriteLine("Would you like to play again? (y/n)");
      string userResponse = Console.ReadLine();
      if (userResponse == "y")
      {
        PlayTheGame();
      }
      else
      {
        Console.WriteLine("See ya lata' suckaaa...");
      }

    }
  }
}