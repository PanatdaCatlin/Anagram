
using System;
using System.Text;

namespace Anagram
{
  public class Word
  {
    private string _word;

    public Word (string newWord)
    {
      _word = newWord;
    }

    public bool CompareWord(string secondWord)
    {
    char[] char1 = _word.ToCharArray();
    char[] char2 = secondWord.ToCharArray();

    Array.Sort(char1);
    Array.Sort(char2);

    string newWord1 = new string(char1);
    string newWord2 = new string(char2);

    for(int i = 0; i < newWord1.Length; i++)
      if(newWord2[i] == newWord1[i])
      {
        return true;
      }
      return false;
    }

  }
}
