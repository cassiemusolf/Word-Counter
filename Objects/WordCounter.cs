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
    public string CountRepeats()
    {
      string[] array = GetUserString().Split(' ');

        foreach (string newString in array)
        {
          return newString;
        }
        return null;
  }
  }
}
