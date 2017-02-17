using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects

{
  public class RepeatCounter
  {
    public string _userString;

    //Getter
    public string GetUserString()
    {
      return _userString;
    }

    //Constructor
    public RepeatCounter(string newUserString)
    {
      _userString = newUserString;
    }

    //Main Method
    public int CountRepeats()
    {
      string[] array = GetUserString().Split(' ');

      int result = 0;
      foreach(string word in array)
      {
        if (word == "dog")
        {
        result += 1;
      }
    }
      return result;
    }
  }
}
