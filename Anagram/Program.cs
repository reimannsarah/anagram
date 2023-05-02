using System;
using Anagram.Models;
using Anagram.UserInterfaceModels;

namespace Anagram
{
  class Program
  {
    static void Main()
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
      Console.WriteLine("Would you like to test another word?");
      Console.WriteLine("type 'yes' if you'd like to test more words, 'no' if you're ready to analyze your anagram(s)");
      string YesOrNo = Console.ReadLine();
      if (YesOrNo == "yes")
      {
        AddMoreWords();
      }
      else 
      {
        Console.WriteLine();
      }

    }

  }
}