using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("folly");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_SetsFieldValueToWord_Word()
    {
      string expected = "folly";
      Word newWord = new Word("folly");
      Assert.AreEqual(expected, newWord.UserWord);
    }

    [TestMethod]
    public void WordArraySort_ArraysAndSortsWord_Array()
    {
      string expected = "abder";
      Word newWord = new Word("beard");
      Assert.AreEqual(expected, Word.ArraySortJoin(Word.WordList[0]));
    }

    [TestMethod]
    public void WordList_AddsWordsToList_List()
    {
      Word newWord = new Word("beard");
      Word anotherWord = new Word("bread");
      List<string> expected = new List<string> {"beard", "bread"};
      CollectionAssert.AreEqual(expected, Word.GetAll());
    }
  }
}